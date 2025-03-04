class singleton
{

public String Mensaje;

    private static singleton instance = null;
    protected singleton(){
this.Mensaje = "hola mundo";
    }
public static singleton Instance{


    get {


        if (instance == null)
        instance= new singleton();
        return instance;
    }
}

}