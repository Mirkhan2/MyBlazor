namespace MyBlazor.Component
{
    public class TableHeaderName
    {
        public TableHeaderName(string name,int colspan =1 )
        {
            Name1 = name;
            Colspan = colspan;
        }
        public int Colsoan { get; set; }
        public int Name { get; set; }
        public string Name1 { get; }
        public int Colspan { get; }
    }
}
