namespace NetPaternContinue.App.Facade_Singleton
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade _instancia = new EmpresaFacade();

        private EmpresaFacadeSingleton() { }

        public static EmpresaFacade GetInstance() => _instancia;
    }
}
