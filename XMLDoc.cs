using System.Text;

namespace ExcelToXml
{
    internal static class XMLDoc
    {
        public static string RepairNode(string value)
        {
            string result = value.Replace(".", string.Empty);

            if (result.Contains("&"))
            {
                result = $"<![CDATA[{ result }]]>";
            }
                
            return result;
        }

        public static void AddNode(StringBuilder sb, int colNum, int rowNum, string value = "")
        {
            string node = SetNode(colNum, rowNum, value);
            sb.AppendLine(node);
        }

        private static string SetNode(int colNum, int rowNum, string value)
        {
            string prefix;
            
            switch (colNum)
            {
                case 7: case 14: case 15:
                    prefix = "D";
                    break;
                case 16: case 17: case 20:
                    prefix = "";
                    break;
                default:
                    prefix = "S"; 
                    break;
            }

            return $"\t\t<T1RXXXXG{colNum}{prefix} ROWNUM=\"{rowNum}\">{value}</T1RXXXXG{colNum}{prefix}>";

        }

        public static string getHeader(string outputFileName)
        {
            string[] headerItems =
            {
                "<?xml version=\"1.0\" encoding=\"windows-1251\"?>",
                "<DECLAR xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:noNamespaceSchemaLocation=\"J0147106.xsd\">",
                "\t<DECLARHEAD>",
                "\t\t<TIN>00191218</TIN>",
                "\t\t<C_DOC>J01</C_DOC>",
                "\t\t<C_DOC_SUB>471</C_DOC_SUB>",
                "\t\t<C_DOC_VER>6</C_DOC_VER>",
                "\t\t<C_DOC_TYPE>0</C_DOC_TYPE>",
                "\t\t<C_DOC_CNT>1</C_DOC_CNT>",
                "\t\t<C_REG>32</C_REG>",
                "\t\t<C_RAJ>0</C_RAJ>",
                "\t\t<PERIOD_MONTH>12</PERIOD_MONTH>",
                "\t\t<PERIOD_TYPE>5</PERIOD_TYPE>",
                "\t\t<PERIOD_YEAR>2020</PERIOD_YEAR>",
                "\t\t<C_STI_ORIG>3200</C_STI_ORIG>",
                "\t\t<C_DOC_STAN>1</C_DOC_STAN>",
                "\t\t<LINKED_DOCS>",
                "\t\t\t<DOC NUM=\"1\" TYPE=\"2\">",
                "\t\t\t\t<C_DOC>J01</C_DOC>",
                "\t\t\t\t<C_DOC_SUB>047</C_DOC_SUB>",
                "\t\t\t\t<C_DOC_VER>6</C_DOC_VER>",
                "\t\t\t\t<C_DOC_TYPE>0</C_DOC_TYPE>",
                "\t\t\t\t<C_DOC_CNT>1</C_DOC_CNT>",
                "\t\t\t\t<C_DOC_STAN>1</C_DOC_STAN>",
                $"\t\t\t\t<FILENAME>{ outputFileName }</FILENAME>",
                "\t\t\t</DOC>",
                "\t\t</LINKED_DOCS>",
                $"\t\t<D_FILL>{ DateTime.UtcNow.Date.ToString("ddMMyyyy") }</D_FILL>",
                "\t\t<SOFTWARE>MEDOC</SOFTWARE>",
                "\t</DECLARHEAD>",
                "\t<DECLARBODY>",
                "\t\t<HZ>1</HZ>",
                "\t\t<HNUM>1</HNUM>",
                "\t\t<HZY>2020</HZY>",
                "\t\t<R00G1>01</R00G1>",
                "\t\t<R01G1S>Minerfin a.s.</R01G1S>",
                "\t\t<R01G2S>Словаччина</R01G2S>",
                "\t\t<R01G3S>703</R01G3S>",
                "\t\t<R01G4S>Площа Людовіта Штура 2 Братислава 811 02 Словаччина</R01G4S>",
                "\t\t<R01G5S>31401333</R01G5S>",
                "\t\t<R03G1S>010</R03G1S>",
                "\t\t<R03G2S xsi:nil=\"true\" />",
                "\t\t<R03G3S xsi:nil=\"true\" />",
                "\t\t<R03G4S xsi:nil=\"true\" />",
                "\t\t<R04G1S>501</R04G1S>",
                "\t\t<R04G2S xsi:nil=\"true\" />",
                "\t\t<R04G3S xsi:nil=\"true\" />",
                "\t\t<R04G4S xsi:nil=\"true\" />"
            };

            StringBuilder sb = new StringBuilder();

            foreach (string item in headerItems)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }
    }
}
