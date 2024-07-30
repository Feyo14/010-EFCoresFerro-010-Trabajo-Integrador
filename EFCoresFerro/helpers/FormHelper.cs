namespace EFCoreFerro2.GUI.Helpers
{
    public static class FormHelper
    {
        public static int CalcularPaginas(int records, int pageSize)
        {
            if (records < pageSize) { return 1; }
            if (records % pageSize == 0) { return records / pageSize; }
            return records / pageSize + 1;
        }
    }
}
