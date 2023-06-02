using System;

public class Pessoa 
{
    private string nome;
    private string cpf;
    private int idade;
    private string sexo;
    private double altura;
    private double peso;

    public Pessoa(string nome, string cpf, int idade, string sexo, double altura, double peso)
    { 
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.sexo = sexo; 
        this.altura = altura;
        this.peso = peso;
    }
    //gets
    public string GetNome()
    {
        return nome;
    }
    public string GetCpf()
    {
        return cpf;
    }
    public int GetIdade()
    {
        return idade;
    }
    public string GetSexo()
    {
        return sexo;
    }
    public double GetAltura()
    {
        return altura;
    }
    public double GetPeso()
    {
        return peso;
    }

    //sets
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public void SetCpf(string cpf)
    {
        this.cpf = cpf;
    }
    public void SetIdade(int idade)
    {
        this.idade = idade;
    }
    public void SetSexo(string sexo)
    {
        this.sexo = sexo;
    }
    public void SetAltura(double altura)
    {
        this.altura = altura;
    }
    public void SetPeso(double peso)
    {
        this.peso = peso;
    }

    public (double, string, string) CalcIMC()
    {
        double imc = peso / Math.Pow(altura, 2);

        if(imc < 18.5)
        {
            return(imc, "Magreza", "Grau de obesidade: 0.");
        }
        else if(imc >= 18.5 && imc < 25)
        {
            return (imc, "Normal", "Grau de obesidade: 0.");
        }
        else if(imc >= 25 &&  imc < 30)
        {
            return (imc, "Sobrepeso", "Grau de obesidade: I.");
        }
        else if(imc >= 30 && imc < 40)
        {
            return (imc, "Obesidade", "Grau de obesidade: II.");
        }
        else if(imc >= 40)
        {
            return (imc, "Obesidade grave", "Grau de obesidade: III.");
        }

      return (imc, "", "");
    }
}