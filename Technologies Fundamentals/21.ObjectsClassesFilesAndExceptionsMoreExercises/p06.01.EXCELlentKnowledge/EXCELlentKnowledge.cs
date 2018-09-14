namespace p06._01.EXCELlentKnowledge
{
    using System;

    class EXCELlentKnowledge
    {
        static void Main(string[] args)
        {
            var xlsApp = new MyExcel.Application();
            var xlsWorkbook = xlsApp.Workbooks.Open(@"C:\Users\todor\Desktop\sample_table.xlsx");
            var xlsSheet = xlsWorkbook.Sheets[1];
            var range = xlsSheet.UsedRange;

        }
    }
}
