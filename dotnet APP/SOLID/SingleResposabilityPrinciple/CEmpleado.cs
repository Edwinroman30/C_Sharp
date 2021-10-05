using System;

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
