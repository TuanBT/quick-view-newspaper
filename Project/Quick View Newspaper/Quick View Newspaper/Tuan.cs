using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Quick_View_Newspaper
{
    class Tuan
    {
        public List<Label> lblList = new List<Label>();
        public List<string> kinhTe = new List<string>();
        public List<string> vanHoa = new List<string>();
        public List<string> theThao = new List<string>();

        
        void AddData()
        {
            for (int i = 1; i <= 10; i++)
            {

                kinhTe.Add("Kinh tế " + i);
            }
            for (int i = 1; i <= 5; i++)
            {

                vanHoa.Add("Văn hóa " + i);
            }
            for (int i = 1; i <= 20; i++)
            {

                theThao.Add("Thể thao " + i);
            }
        }

        //List category
        void AddToLable(List<string> listCategory)
        {
            Label lbl;
            if (listCategory.Count <= 0) return;
            else
            {
                foreach (string str in listCategory)
                {
                    lbl = new Label();
                    lbl.Text = str;
                    lblList.Add(lbl);
                }
            }
        }

        public void print()
        {
            AddData();
            AddToLable(kinhTe);
            foreach (Label lbl in lblList)
            {
                Console.WriteLine(lbl.Text);
            }
        }
    }
}
