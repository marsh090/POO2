namespace Aula0
{
    internal class PopulacaoBarata
    {

        public int QtdeBaratas = 0;

        public PopulacaoBarata()
        {
            this.QtdeBaratas = 100;
        }

        public int GetQtdeBaratas()
        {
            return this.QtdeBaratas;
        }

        public void Spray()
        {
            this.QtdeBaratas = (int)(this.QtdeBaratas * 0.9);
        }

        public void Procria()
        {
            this.QtdeBaratas = (int)(this.QtdeBaratas * 1.5);
        }


    }
}