using System.Runtime.Serialization;
using Internal;
using System;

namespace SingleResponsabilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado emp = new CEmpleado("Edwin",'M',28599f);
            Console.WriteLine("Hello World!");
            Console.WriteLine(emp.ToString());
        }
    }

    class CEmpleado{


    private string _nombre;
    private char _sexo;
    private float _salario; 

    public CEmpleado(string pnombre, char psexo, float psalario){

        this._nombre = pnombre;
        this._sexo = psexo;
        this._salario = psalario;
        
        Console.WriteLine("COnstructor");
    }

/*     public override string ToString(){
        return "Una cadena override...";
    } */

}
}

