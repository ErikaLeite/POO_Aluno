namespace POO_Aluno.classes
{
    public class Aluno
    {
        //Vamos desenvolver um programa que cadastre e mostre um aluno. Criando uma classe aluno com as seguintes propriedades: Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. Também teremos os métodos: VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.
        public string nome;
        public string curso; 
        public float idade;
        public string rg;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;

        public float VerMediaFinal()
        {
            return this.mediaFinal;
        }

        public float VerMensalidade()
        {   float valor= 0;
            if(bolsista == true && mediaFinal >=7){
                valor = this.valorMensalidade * 0.5f;
            }else{
                valor = this.valorMensalidade;
            }

            return valor;
        }

    }
}