using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS452_Project3_MemoryManagement.model;
using System.IO;

namespace CIS452_Project3_MemoryManagement.controller
{
    class Controller
    {
        /// <summary>
        /// State of computer at all states...Not mem efficient
        /// </summary>
        private List<Computer> history;
        /// <summary>
        /// List of all commands executed.
        /// </summary>
        private List<String> commands;
        /// <summary>
        /// Current cpu state.
        /// </summary>
        private Computer currentCPU;
        /// <summary>
        /// Initial cpu state. Used when computer reset.
        /// </summary>
        private Computer initialCPU;
        /// <summary>
        /// Current step number.
        /// </summary>
        private int step;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Controller()
        {
            history = new List<Computer>();
            commands = new List<String>();
        }

        /// <summary>
        /// Method starts a new computer with memory matching parameters.
        /// </summary>
        /// <param name="physicalMemorySize">Size of physical memory.</param>
        /// <param name="pageSize">Size of a page in memory.</param>
        /// <returns>True on success, False otherwise.</returns>
        public Boolean StartComputer(int physicalMemorySize, int pageSize)
        {
            Boolean successfullStart = true;
            try
            {
                currentCPU = new Computer(physicalMemorySize, pageSize);
                initialCPU = currentCPU.Copy();
                history.Add(currentCPU.Copy());
                commands.Add("Initialized CPU");
                step = 0;
            }
            catch (Exception)
            {
                successfullStart = false;
            }
            return successfullStart;
        }


        /// <summary>
        /// Method restarts computer to initial state if it exists.
        /// </summary>
        /// <returns>True on success, False otherwise.</returns>
        public Boolean RestartComputer()
        {
            Boolean success = false;
            if (initialCPU != null)
            {
                history.Clear();
                commands.Clear();
                currentCPU = initialCPU.Copy();
                history.Add(currentCPU.Copy());
                commands.Add("Initialized CPU");
                step = 0;
                success = true;
            }
            return success;
        }

        /// <summary>
        /// Method deletes the current computer configuration.
        /// </summary>
        /// <returns>True on success, False otherwise.</returns>
        public Boolean DestroyComputer()
        {
            Boolean success = false;
            if (initialCPU != null)
            {
                history.Clear();
                commands.Clear();
                currentCPU = null;
                initialCPU = null;
                success = true;
            }
            return success;
        }

        /// <summary>
        /// Method moves computer back one step.
        /// </summary>
        /// <returns>True on success, False otherwise.</returns>
        public Boolean PreviousStep()
        {
            if (step - 1 > -1)
            {
                step--;
                currentCPU = history[step];
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method moves computer forwared one step.
        /// </summary>
        /// <returns>True on success, False otherwise.</returns>
        public Boolean NextStep()
        {
            if (step + 1< history.Count)
            {
                step++;
                if (step == history.Count - 1)
                {
                    currentCPU = history[step].Copy();
                }
                else
                {
                    currentCPU = history[step];
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method jumps computer state to particular step in history.
        /// </summary>
        /// <param name="step">Index in history to step to.</param>
        /// <returns>True on success, False otherwise.</returns>
        public Boolean JumpToStep(int step)
        {
            if (step > -1 && step < history.Count)
            {
                this.step = step;
                if (step == history.Count - 1)
                {
                    currentCPU = history[step].Copy();
                }
                else
                {
                    currentCPU = history[step];
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Gets the previous command in histroy.
        /// </summary>
        /// <returns>Previous command in history.</returns>
        public String GetLastCommand()
        {
            return commands[step];
        }

        /// <summary>
        /// Gets the current command to be executed if it exists.
        /// </summary>
        /// <returns>Next command to be executed.</returns>
        public String GetCurrentCommand()
        {
            if (step + 1 == history.Count)
            {
                return "";
            }
            return commands[step + 1];
        }

        /// <summary>
        /// Gets the number of steps in history.
        /// </summary>
        /// <returns>Number of steps in history.</returns>
        public int GetSteps()
        {
            return history.Count;
        }

        /// <summary>
        /// Gets the current step index.
        /// </summary>
        /// <returns>Current step index.</returns>
        public int GetStepIndex()
        {
            return step;
        }

        /// <summary>
        /// Spawns a new process with text size of textSize and
        /// data size of dataSize.
        /// </summary>
        /// <param name="textSize">Number of bytes to allocate in 
        /// text section.</param>
        /// <param name="dataSize">Number of bytes to allocate in
        /// data section.</param>
        /// <returns>Pid of spawned process or -1 if failed.</returns>
        public int SpawnProcess(int textSize, int dataSize)
        {
            if (step + 1 != history.Count)
            {
                return -1;
            }
            List<Segment> segs = new List<Segment>();
            List<int> sizes = new List<int>();
            segs.Add(Segment.Text);
            segs.Add(Segment.Data);
            sizes.Add(textSize);
            sizes.Add(dataSize);
            int pidResult = currentCPU.SpawnProcess(segs, sizes);
            if ( pidResult > -1)
            {
                history.Add(currentCPU.Copy());
                commands.Add("Spawn " + textSize.ToString() + " " +
                    dataSize.ToString());
                step++;
            }
            return pidResult;
        }

        /// <summary>
        /// Terminates process pid.
        /// </summary>
        /// <param name="pid">Pid to terminate.</param>
        /// <returns>True on success, False otherwise.</returns>
        public Boolean TerminateProcess(int pid)
        {
            if (step + 1 != history.Count)
            {
                return false;
            }
            Boolean isTerminated = currentCPU.TerminateProcess(pid);
            if (isTerminated)
            {
                history.Add(currentCPU.Copy());
                commands.Add("Terminate " + pid.ToString());
                step++;
            }
            return isTerminated;
        }

        /// <summary>
        /// Gets the next PID in computer process list.
        /// </summary>
        /// <param name="pid">Lookup pid.</param>
        /// <returns>Next pid in computer process list.</returns>
        public int GetNextPID(int pid)
        {
            return currentCPU.GetNextPID(pid);
        }

        /// <summary>
        /// Gets the previous pid in computer process list.
        /// </summary>
        /// <param name="pid">Lookup pid.</param>
        /// <returns>Previous pid in computer process list.</returns>
        public int GetPreviousPID(int pid)
        {
            return currentCPU.GetPreviousPID(pid);
        }

        /// <summary>
        /// Method attempts to interpret a commmand and then execute it.
        /// </summary>
        /// <param name="command">Command to interpret.</param>
        /// <returns>True on success, False otherwise.</returns>
        public Boolean InterpretCommand(String command)
        {
            String[] args;
            try
            {
                args = command.Split(' ');
            }
            catch (Exception)
            {
                return false;
            }

            if (args.Length < 1)
            {
                return false;
            }

            switch (args[0])
            {
                case "Spawn":
                    if (args.Length == 3)
                    {
                        int textLength;
                        int dataLength;
                        try
                        {
                            textLength = Convert.ToInt32(args[1]);
                            dataLength = Convert.ToInt32(args[2]);
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                        if (SpawnProcess(textLength, dataLength) == -1)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case "Terminate":
                    if (args.Length == 2)
                    {
                        int processToTerminate;
                        try
                        {
                            processToTerminate = Convert.ToInt32(args[1]);
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                        if (!TerminateProcess(processToTerminate))
                        {
                            return false;
                        }
                    }
                    break;
                default:
                    return false;
            }
            return true;

        }

        /// <summary>
        /// Method loads a script in and executes all of the commands.
        /// The state of the computer is set to step 0.
        /// </summary>
        /// <param name="path">Location of file to execute.</param>
        /// <returns>True on success, False otherwise.</returns>
        public Boolean LoadScript(String path)
        {
            if (step + 1 != history.Count)
            {
                return false;
            }
            StreamReader sr;
            try
            {
                sr = new StreamReader(path);
            }
            catch (Exception)
            {
                return false;
            }
            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();
                InterpretCommand(line);
            }
            JumpToStep(0);
            return true;

        }

        /// <summary>
        /// Method gets view information from computer.
        /// </summary>
        /// <param name="physicalMemoryRowIndex"></param>
        /// <param name="process"></param>
        /// <param name="pageTableIndex"></param>
        /// <returns>All variables used in setting the view.</returns>
        public ViewState GetViewState(int physicalMemoryRowIndex,
            int process, int pageTableIndex)
        {
            ViewState viewState = new ViewState();
            viewState.MemorySize = currentCPU.GetMemorySize();
            viewState.PageCount = currentCPU.GetPageCount();
            viewState.PageSize = currentCPU.GetPageSize();
            viewState.PagesUsed = currentCPU.GetPagesUsed();

            // get number of pages
            List<PhysicalMemoryRowView> rows = 
                new List<PhysicalMemoryRowView>();
            for (int i = physicalMemoryRowIndex; i < currentCPU.GetPageCount() 
                && i < physicalMemoryRowIndex + 12; i++)
            {
                rows.Add(currentCPU.GetPhysicalMemoryRow(i));
            }
            viewState.Rows = rows;

            // get process info
            viewState.PageTableRows = 
                currentCPU.GetProcessPageTable(process, pageTableIndex);
            viewState.ProcessPageCount = 
                currentCPU.GetProcessPageCount(process);
            return viewState;
        }
    }
}
