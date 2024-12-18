using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Entrada.ViewModel.Variaveis
{
    public class GVL
    {

        public class ExitProgram
        {
            private static object lockObjectFor_xContinueRunning = new object();
            private static bool? _xContinueRunning;
            public static bool? xContinueRunning
            {
                get
                {
                    lock (lockObjectFor_xContinueRunning)
                    {
                        return _xContinueRunning;
                    }
                }
                set
                {
                    lock (lockObjectFor_xContinueRunning)
                    {
                        _xContinueRunning = value;
                    }
                }
            }
        }

        public class StatusCamer
        {
            private static object lockObjectFor_xStatusCamera = new object();
            private static bool? _xStatusCamera;
            public static bool? xStatusCamera
            {
                get
                {
                    lock (lockObjectFor_xStatusCamera)
                    {
                        return _xStatusCamera;
                    }
                }
                set
                {
                    lock (lockObjectFor_xStatusCamera)
                    {
                        _xStatusCamera = value;
                    }
                }
            }
            private static object lockObjectFor_sTempoStatusCamera = new object();
            private static string? _sTempoStatusCamera;
            public static string? sTempoStatusCamera
            {
                get
                {
                    lock (lockObjectFor_sTempoStatusCamera)
                    {
                        return _sTempoStatusCamera;
                    }
                }
                set
                {
                    lock (lockObjectFor_sTempoStatusCamera)
                    {
                        _sTempoStatusCamera = value;
                    }
                }
            }

        }



        public class Tempo
        {
            private static object lockObjectFor_sDataCompleta = new object();
            private static string? _sDataCompleta;
            public static string? sDataCompleta
            {
                get
                {
                    lock (lockObjectFor_sDataCompleta)
                    {
                        return _sDataCompleta;
                    }
                }
                set
                {
                    lock (lockObjectFor_sDataCompleta)
                    {
                        _sDataCompleta = value;
                    }
                }
            }
        }




        public class Opcua
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
