using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Entrada.ViewModel.Variaveis
{
    class GVL
    {
        class Opcua
        {
            public class Read
            {
                public class ClpCamera
                {
                    private static object lockObjectFor_uNumeroCargaRelEntrada = new object();
                    private static int? _uNumeroCargaRelEntrada;
                    public static int? uNumeroCargaRelEntrada
                    {
                        get
                        {
                            lock (lockObjectFor_uNumeroCargaRelEntrada)
                            {
                                return _uNumeroCargaRelEntrada;
                            }
                        }
                        set
                        {
                            lock (lockObjectFor_uNumeroCargaRelEntrada)
                            {
                                _uNumeroCargaRelEntrada = value;
                            }
                        }
                    }
                    private static object lockObjectFor_xIniciaRelatorioCameraEntrada = new object();
                    private static bool? _xIniciaRelatorioCameraEntrada;
                    public static bool? xIniciaRelatorioCameraEntrada
                    {
                        get
                        {
                            lock (lockObjectFor_xIniciaRelatorioCameraEntrada)
                            {
                                return _xIniciaRelatorioCameraEntrada;
                            }
                        }
                        set
                        {
                            lock (lockObjectFor_xIniciaRelatorioCameraEntrada)
                            {
                                _xIniciaRelatorioCameraEntrada = value;
                            }
                        }
                    }
                }
            }
            public class Write
            {
                public class ClpCamera
                {
                    internal static bool Write_xIniciaRelatorioCameraEntrada;
                    private static object lockObjectFor_xIniciaRelatorioCameraEntrada = new object();
                    private static bool? _xIniciaRelatorioCameraEntrada;
                    public static bool? xIniciaRelatorioCameraEntrada
                    {
                        get
                        {
                            lock (lockObjectFor_xIniciaRelatorioCameraEntrada)
                            {
                                return _xIniciaRelatorioCameraEntrada;
                            }
                        }
                        set
                        {
                            lock (lockObjectFor_xIniciaRelatorioCameraEntrada)
                            {
                                _xIniciaRelatorioCameraEntrada = value;
                            }
                        }
                    }
                }
                public static bool? Write_xIniciaRelatorioCameraEntrada;
            }
        }






    }
}
