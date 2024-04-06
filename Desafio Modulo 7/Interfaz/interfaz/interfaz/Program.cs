public interface INotificable
{
    void Notifica();
}

public class NotificacionEmail : INotificable
{
    public string DireccionCorreo { get; set; }

    public NotificacionEmail(string direccionCorreo)
    {
        DireccionCorreo = direccionCorreo;
    }

    public void Notifica()
    {
        Console.WriteLine($"Enviando email a {DireccionCorreo}");
    }
}

public class NotificacionWhatsapp : INotificable
{
    public string NumeroTelefono { get; set; }

    public NotificacionWhatsapp(string numeroTelefono)
    {
        NumeroTelefono = numeroTelefono;
    }

    public void Notifica()
    {
        Console.WriteLine($"Enviando Whatsapp a {NumeroTelefono}");
    }
}

public class NotificacionSMS : INotificable
{
    public string NumeroTelefono { get; set; }

    public NotificacionSMS(string numeroTelefono)
    {
        NumeroTelefono = numeroTelefono;
    }

    public void Notifica()
    {
        Console.WriteLine($"Enviando SMS a {NumeroTelefono}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        NotificacionEmail email = new NotificacionEmail("ejemplo@correo.com");
        NotificacionWhatsapp whatsapp = new NotificacionWhatsapp("33839481");
        NotificacionSMS sms = new NotificacionSMS("51637717");

        email.Notifica();
        whatsapp.Notifica();
        sms.Notifica();
    }
}