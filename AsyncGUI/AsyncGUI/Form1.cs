using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncGUI
{
    public partial class Form1 : Form
    {
        private MethodType currMethod { get; set; }

        public static DirectoryInfo rootDir { get; set; }
        public static Dictionary<string, string> Found_Dirs { get; set; }
        public static IterationType currIterator { get; set; }

        public Form1()
        {
            InitializeComponent();

            serialRB.Checked = true;
            nonParallelRB.Checked = true;
            Found_Dirs = new Dictionary<string, string>();

            serialRB.Enabled = true;
            singleThreadRB.Enabled = false;
            multiThreadRB.Enabled = false;
            threadPoolRB.Enabled = false;
            parallelForRB.Enabled = false;
            waitAnyRB.Enabled = false;
            waitAllRB.Enabled = false;
            awaitRB.Enabled = false;

            nonParallelRB.Enabled = true;
            parallelRB.Enabled = true;

            noRecursionRB.Enabled = true;
            recursionRB.Enabled = true;
            stackRB.Enabled = false;
        }

        #region Events

        #region Mouse

        #region Click

        #region button2

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                Description = "Select Root Folder To Display"
            };

            fbd.ShowDialog();
            textBox1.Text = fbd.SelectedPath;
        }

        #endregion button2

        #region button1

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch time = new Stopwatch();

            listView1.Items.Clear();
            time.Start();

            if (textBox1.Text != "")
            {
                rootDir = new DirectoryInfo(textBox1.Text);

                if (rootDir.Exists)
                {
                    #region Non Parallel Enumerable

                    if (nonParallelRB.Checked)
                    {
                        switch (currMethod)
                        {
                            case MethodType.Async_Await:
                                break;

                            case MethodType.Multi_Thread:
                                break;

                            case MethodType.Parallel_For:
                                break;

                            case MethodType.Serial:
                                Serial(false);
                                Update_ListView();
                                break;

                            case MethodType.Single_Thread:
                                break;

                            case MethodType.Task_All:
                                break;

                            case MethodType.Task_Any:
                                break;

                            case MethodType.Thread_Pool:
                                break;
                        }
                    }

                    #endregion Non Parallel Enumerable

                    #region Parallel Enumerable

                    else
                    {
                        listView1.Columns[0].Text = "Parallel Enumerable";
                        listView1.Refresh();
                        switch (currMethod)
                        {
                            case MethodType.Async_Await:
                                break;

                            case MethodType.Multi_Thread:
                                break;

                            case MethodType.Parallel_For:
                                break;

                            case MethodType.Serial:
                                Serial(true);
                                Update_ListView();
                                break;

                            case MethodType.Single_Thread:
                                break;

                            case MethodType.Task_All:
                                break;

                            case MethodType.Task_Any:
                                break;

                            case MethodType.Thread_Pool:
                                break;
                        }
                    }

                    #endregion Parallel Enumerable
                }
            }

            time.Stop();

            timeResultLB.Text = "Total Time: " + time.Elapsed.TotalSeconds.ToString() + " seconds";

            if (Found_Dirs.Count > 0)
            {
                foreach (KeyValuePair<string, string> kvp in Found_Dirs)
                {
                    listView1.Items.Add(kvp.Key + " - " + kvp.Value);
                }
            }
        }

        #endregion button1

        #endregion Click

        #region Enter
        #endregion Enter

        #region Leave
        #endregion Leave

        #endregion Mouse

        #region Radio Button

        #region CheckedChanged

        #region serialRB

        private void serialRB_CheckedChanged(object sender, EventArgs e)
        {
            if (serialRB.Checked)
            {
                currMethod = MethodType.Serial;
            }
        }

        #endregion serialRB

        #region singleThreadRB

        private void singleThreadRB_CheckedChanged(object sender, EventArgs e)
        {
            if (singleThreadRB.Checked)
            {
                currMethod = MethodType.Single_Thread;
            }
        }

        #endregion singleThreadRB

        #region multiThreadRB

        private void multiThreadRB_CheckedChanged(object sender, EventArgs e)
        {
            if (multiThreadRB.Checked)
            {
                currMethod = MethodType.Multi_Thread;
            }
        }

        #endregion multiThreadRB

        #region threadPoolRB

        private void threadPoolRB_CheckedChanged(object sender, EventArgs e)
        {
            if (threadPoolRB.Checked)
            {
                currMethod = MethodType.Thread_Pool;
            }
        }

        #endregion threadPoolRB

        #region parallelForRB

        private void parallelForRB_CheckedChanged(object sender, EventArgs e)
        {
            if (parallelForRB.Checked)
            {
                currMethod = MethodType.Parallel_For;
            }
        }

        #endregion parallelForRB

        #region waitAnyRB

        private void waitAnyRB_CheckedChanged(object sender, EventArgs e)
        {
            if (waitAnyRB.Checked)
            {
                currMethod = MethodType.Task_Any;
            }
        }

        #endregion waitAnyRB

        #region waitAllRB

        private void waitAllRB_CheckedChanged(object sender, EventArgs e)
        {
            if (waitAllRB.Checked)
            {
                currMethod = MethodType.Task_All;
            }
        }

        #endregion waitAllRB

        #region awaitRB

        private void awaitRB_CheckedChanged(object sender, EventArgs e)
        {
            if (awaitRB.Checked)
            {
                currMethod = MethodType.Async_Await;
            }
        }

        #endregion awaitRB

        #region noRecursionRB

        private void noRecursionRB_CheckedChanged(object sender, EventArgs e)
        {
            if (noRecursionRB.Checked)
            {
                currIterator = IterationType.Non_Recursive;
            }
        }

        #endregion noRecursionRB

        #region recursionRB

        private void recursionRB_CheckedChanged(object sender, EventArgs e)
        {
            if (recursionRB.Checked)
            {
                currIterator = IterationType.Recursive;
            }
        }

        #endregion recursionRB

        #region stackRB

        private void stackRB_CheckedChanged(object sender, EventArgs e)
        {
            if (stackRB.Checked)
            {
                currIterator = IterationType.Stack;
            }
        }

        #endregion stackRB

        #endregion CheckedChanged

        #endregion Radio Button

        #endregion Events

        #region Methods

        #region Update_ListView()

        /// <summary>
        /// Update the list view using the Found_Dirs enumerable
        /// </summary>
        public void Update_ListView()
        {
            foreach (KeyValuePair<string, string> kvp in Found_Dirs)
            {
                listView1.Items.Add(kvp.Key + " - " + kvp.Value);
            }
        }

        #endregion Update_ListView()

        #region Serial

        /// <summary>
        /// Caller for the serial method of iterating directories.
        /// </summary>
        /// <param name="parallel_Enumerable">Determines what type of enumerable to process as.</param>
        public void Serial(bool parallel_Enumerable)
        {
            if (parallel_Enumerable)
            {
                Serial_Enumerable();
            }

            else
            {
                Serial_Non_Enumerable();
            }
        }

        #region Non-Parallel Enumerable

        public void Serial_Non_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:

                    Serial_Non_Recursive();

                    break;

                case IterationType.Recursive:

                    Serial_Recursive(rootDir);

                    break;

                case IterationType.Stack:

                    break;
            }
        }

        #endregion

        #region Parallel Enumerable

        public void Serial_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:

                    break;

                case IterationType.Recursive:

                    break;

                case IterationType.Stack:

                    break;
            }
        }

        #endregion

        #region Non-Recursive

        public void Serial_Non_Recursive()
        {
            try
            {
                foreach (DirectoryInfo dirInfo in rootDir.GetDirectories("*", SearchOption.AllDirectories))
                {
                    Found_Dirs.Add(dirInfo.Name, dirInfo.FullName);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Non-Recursive

        #region Recursive

        public void Serial_Recursive(DirectoryInfo root)
        {
            try
            {
                foreach (DirectoryInfo dir in root.GetDirectories())
                {
                    Serial_Recursive(dir);

                    try
                    {
                        Found_Dirs.Add(dir.Name, dir.FullName);
                    }
                    catch
                    {
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Recursive

        #region Stack



        #endregion Stack

        #endregion

        #region Single Thread

        /// <summary>
        /// Caller for the single thread method of iterating directories.
        /// Create's a single thread and runs the loop.
        /// </summary>
        /// <param name="parallel_Enumerable">Determines what type of enumerable to process as.</param>
        public void Single_Thread(bool parallel_Enumerable)
        {
            if (parallel_Enumerable)
            {
                Single_Thread_Enumerable();
            }

            else
            {
                Single_Thread_Non_Enumerable();
            }
        }

        #region Non-Parallel Enumerable

        public void Single_Thread_Non_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Parallel Enumerable

        public void Single_Thread_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Non-Recursive



        #endregion Non-Recursive

        #region Recursive



        #endregion Recursive

        #region Stack



        #endregion Stack

        #endregion Single Thread

        #region Multiple Threads

        /// <summary>
        /// The multiple thread method of iterating directories.
        /// Creates seperate threads for each directory to do processing
        /// </summary>
        /// <param name="parallel_Enumerable">Determines what type of enumerable to process as.</param>
        public void Multi_Thread(bool parallel_Enumerable)
        {
            if (parallel_Enumerable)
            {
                Multi_Thread_Enumerable();
            }

            else
            {
                Multi_Thread_Non_Enumerable();
            }
        }

        #region Non-Parallel Enumerable

        public void Multi_Thread_Non_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Parallel Enumerable

        public void Multi_Thread_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Non-Recursive



        #endregion Non-Recursive

        #region Recursive



        #endregion Recursive

        #region Stack



        #endregion Stack

        #endregion Multiple Threads

        #region Thread Pool

        /// <summary>
        /// The thread pool method of iterating directories.
        /// Uses the a thread from the thread pool to iterate, only using single thread method here.
        /// </summary>
        /// <param name="parallel_Enumerable">Determines what type of enumerable to process as.</param>
        public void Thread_Pool(bool parallel_Enumerable)
        {
            if (parallel_Enumerable)
            {
                Thread_Pool_Enumerable();
            }

            else
            {
                Thread_Pool_Non_Enumerable();
            }
        }

        #region Non-Parallel Enumerable

        public void Thread_Pool_Non_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Parallel Enumerable

        public void Thread_Pool_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Non-Recursive



        #endregion Non-Recursive

        #region Recursive



        #endregion Recursive

        #region Stack



        #endregion Stack

        #endregion Thread Pool

        #region Parallel For Each

        /// <summary>
        /// The parallel for each method of iterating directories.
        /// Uses the parallel for each loop to iterate.
        /// </summary>
        /// <param name="parallel_Enumerable">Determines what type of enumerable to process as.</param>
        public void Parallel_For_Each(bool parallel_Enumerable)
        {
            if (parallel_Enumerable)
            {
                Parallel_For_Each_Enumerable();
            }

            else
            {
                Parallel_For_Each_Non_Enumerable();
            }
        }

        #region Non-Parallel Enumerable

        public void Parallel_For_Each_Non_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Parallel Enumerable

        public void Parallel_For_Each_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Non-Recursive



        #endregion Non-Recursive

        #region Recursive



        #endregion Recursive

        #region Stack



        #endregion Stack

        #endregion Parallel For Each

        #region Task Wait Any

        /// <summary>
        /// The task await any method of iterating directoreis.
        /// Experimental - Performs actions whenever any of the task's in a task list complete.
        /// Perhaps updating the list view upon addition to the found list.
        /// </summary>
        /// <param name="parallel_Enumerable">Determines what type of enumerable to process as.</param>
        public void Task_Await_Any(bool parallel_Enumerable)
        {
            if (parallel_Enumerable)
            {
                Task_Await_Any_Enumerable();
            }

            else
            {
                Task_Await_Any_Non_Enumerable();
            }
        }

        #region Non-Parallel Enumerable

        public void Task_Await_Any_Non_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Parallel Enumerable

        public void Task_Await_Any_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Non-Recursive



        #endregion Non-Recursive

        #region Recursive



        #endregion Recursive

        #region Stack



        #endregion Stack

        #endregion Task Wait Any

        #region Task Wait All

        /// <summary>
        /// The task wait all method of iterating directories.
        /// Waits until all tasks in a task list have completed.
        /// </summary>
        /// <param name="parallel_Enumerable">Determines what type of enumerable to process as.</param>
        public void Task_Wait_All(bool parallel_Enumerable)
        {
            if (parallel_Enumerable)
            {
                Task_Await_All_Enumerable();
            }

            else
            {
                Task_Await_All_Non_Enumerable();
            }
        }

        #region Non-Parallel Enumerable

        public void Task_Await_All_Non_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Parallel Enumerable

        public void Task_Await_All_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Non-Recursive



        #endregion Non-Recursive

        #region Recursive



        #endregion Recursive

        #region Stack



        #endregion Stack

        #endregion Task Wait All

        #region Async and Await

        /// <summary>
        /// The async and await method of iterating directories.
        /// </summary>
        /// <param name="parallel_Enumerable">Determines what type of enumerable to process as.</param>
        public void Async_Await(bool parallel_Enumerable)
        {
            if (parallel_Enumerable)
            {
                Async_Await_Enumerable();
            }

            else
            {
                Async_Await_Non_Enumerable();
            }
        }

        #region Non-Parallel Enumerable

        public void Async_Await_Non_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Parallel Enumerable

        public void Async_Await_Enumerable()
        {
            switch (currIterator)
            {
                case IterationType.Non_Recursive:
                    break;

                case IterationType.Recursive:
                    break;

                case IterationType.Stack:
                    break;
            }
        }

        #endregion

        #region Non-Recursive



        #endregion Non-Recursive

        #region Recursive



        #endregion Recursive

        #region Stack



        #endregion Stack

        #endregion Async and Await

        #endregion Methods

        private void nonParallelRB_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Columns[0].Text = "Non Parallel Enumerable";
            listView1.Refresh();
        }

        private void parallelRB_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Columns[0].Text = "Parallel Enumerable";
            listView1.Refresh();
        }
    }

    public enum MethodType
    {
        Serial,
        Single_Thread,
        Multi_Thread,
        Thread_Pool,
        Parallel_For,
        Task_Any,
        Task_All,
        Async_Await
    }

    public enum IterationType
    {
        Non_Recursive,
        Recursive,
        Stack
    }
}
