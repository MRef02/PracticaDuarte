using System;

namespace codigo1.clases;

public class Usuario
{
    private string _name="";
    public string Name
    {
        get { return _name; }
        set
        {
            if (value is null)
            {
                throw new Exception("El usuario debe tener un nombre");
            }
            _name = value;
        }
    }

    private string _mail="";
    public string Mail
    {
        get { return _mail; }
        set
        {
            if (value is null)
            {
                throw new Exception("El usuario debe de tener un mail");
            }
            _mail = value;
        }
    }

    public Usuario(string nombre,string correo)
    {
        Name = nombre;
        Mail = correo;
    }
}
