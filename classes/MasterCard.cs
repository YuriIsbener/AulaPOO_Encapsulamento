namespace AulaPOO_Encapsulamento.classes
{
    public class MasterCard : Cartao
    {
        private int parcelas;


        public int Parcelas{
            get{return parcelas;}
            set{parcelas = value;}
        }

        public string CompraComDesconto(){

            return "";
        }
    }
}