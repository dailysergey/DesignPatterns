using System;

namespace Facade
{
    class Program
    {
        static void Main()
        {
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);

            Console.Read();
        }
    }

    /// <summary>
    /// Text Editor Class with two methods:
    /// <para>CreateCode()</para>
    /// <para>Save()</para>
    /// </summary>
    class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Writing code");
        }
        public void Save()
        {
            Console.WriteLine("Saving...");
        }
    }

    /// <summary>
    /// Compiller Class with method:
    /// <para>Compile()</para>
    /// </summary>
    class Compiller
    {
        public void Compile()
        {
            Console.WriteLine("Code compilation...");
        }
    }

    /// <summary>
    /// CLR Class with two methods:
    /// <para>Execute()</para>
    /// <para>Finish()</para>
    /// </summary>
    class CLR
    {
        public void Execute()
        {
            Console.WriteLine("Executing app...");
        }
        public void Finish()
        {
            Console.WriteLine("Finished app.");
        }
    }

    /// <summary>
    /// VisualStudioFacade Class with two methods:
    /// <para>Start</para>
    /// <para>Stop</para>
    /// </summary>
    class VisualStudioFacade
    {
        readonly TextEditor textEditor;
        readonly Compiller compiller;
        readonly CLR clr;
        public VisualStudioFacade(TextEditor te, Compiller compil, CLR clr)
        {
            this.textEditor = te;
            this.compiller = compil;
            this.clr = clr;
        }

        public void Start()
        {
            textEditor.CreateCode();
            textEditor.Save();
            compiller.Compile();
            clr.Execute();
        }

        public void Stop()
        {
            clr.Finish();
        }
    }

    class Programmer
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
