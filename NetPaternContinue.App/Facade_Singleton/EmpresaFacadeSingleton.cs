namespace NetPaternContinue.App.Facade_Singleton
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade _instancia = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get
            {
                return _instancia;
            }
        }
    }
}
