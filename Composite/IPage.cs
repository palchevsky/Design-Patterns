namespace Composite
{
    interface IPage
    {
        string Header { get; set; }
        string Info { get; set; }
        void Print();
        IPage Find(string header);
    }
}
