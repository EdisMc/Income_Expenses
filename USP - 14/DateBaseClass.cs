using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USP___14
{
    class DataBaseClass
    {
        //db class
        private string Suma;
        private string Data;
        private string Opisanie;
        private string Tip;
        private string Kategoria;
        private string Mesec;

        public DataBaseClass(string Suma, string Data, string Opisanie, string Tip, string Kategoria, string Mesec)
        {
            this.Suma = Suma;
            this.Data = Data;
            this.Opisanie = Opisanie;
            this.Tip = Tip;
            this.Kategoria = Kategoria;
            this.Mesec = Mesec;
        }

        public void setSuma(string Suma)
        {
            this.Suma = Suma;
        }

        public string getSuma()
        {
            return Suma;
        }

        public void setData(string Data)
        {
            this.Data = Data;
        }

        public string getData()
        {
            return Data;
        }

        public void setOpisanie(string Opisanie)
        {
            this.Opisanie = Opisanie;
        }

        public string getOpisanie()
        {
            return Opisanie;
        }

        public void setTip(string Tip)
        {
            this.Tip = Tip;
        }

        public string getTip()
        {
            return Tip;
        }

        public void setKategoria(string Kategoria)
        {
            this.Kategoria = Kategoria;
        }

        public string getKategoria()
        {
            return Kategoria;
        }

        public void setMesec(string Mesec)
        {
            this.Mesec = Mesec;
        }

        public string getMesec()
        {
            return Mesec;
        }


    }
}
