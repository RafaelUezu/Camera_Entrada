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
        public class StatusCamera
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
            private static object lockObjectFor_sTempoRegistroCamera = new object();
            private static string? _sTempoRegistroCamera;
            public static string? sTempoRegistroCamera
            {
                get
                {
                    lock (lockObjectFor_sTempoRegistroCamera)
                    {
                        return _sTempoRegistroCamera;
                    }
                }
                set
                {
                    lock (lockObjectFor_sTempoRegistroCamera)
                    {
                        _sTempoRegistroCamera = value;
                    }
                }
            }
            private static object lockObjectFor_sIdUltimaCarga = new object();
            private static string? _sIdUltimaCarga;
            public static string? sIdUltimaCarga
            {
                get
                {
                    lock (lockObjectFor_sIdUltimaCarga)
                    {
                        return _sIdUltimaCarga;
                    }
                }
                set
                {
                    lock (lockObjectFor_sIdUltimaCarga)
                    {
                        _sIdUltimaCarga = value;
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

        public class StatusOpcua
        {
            private static object lockObjectFor_xStatusIp = new object();
            private static bool? _xStatusIp;
            public static bool? xStatusIp
            {
                get
                {
                    lock (lockObjectFor_xStatusIp)
                    {
                        return _xStatusIp;
                    }
                }
                set
                {
                    lock (lockObjectFor_xStatusIp)
                    {
                        _xStatusIp = value;
                    }
                }
            }
            private static object lockObjectFor_xStatusOpcua = new object();
            private static bool? _xStatusOpcua;
            public static bool? xStatusOpcua
            {
                get
                {
                    lock (lockObjectFor_xStatusOpcua)
                    {
                        return _xStatusOpcua;
                    }
                }
                set
                {
                    lock (lockObjectFor_xStatusOpcua)
                    {
                        _xStatusOpcua = value;
                    }
                }
            }
            private static object lockObjectFor_sTempoCheckIp = new object();
            private static string? _sTempoCheckIp;
            public static string? sTempoCheckIp
            {
                get
                {
                    lock (lockObjectFor_sTempoCheckIp)
                    {
                        return _sTempoCheckIp;
                    }
                }
                set
                {
                    lock (lockObjectFor_sTempoCheckIp)
                    {
                        _sTempoCheckIp = value;
                    }
                }
            }

            private static object lockObjectFor_sTempoRequesicaoOpcua = new object();
            private static string? _sTempoRequesicaoOpcua;
            public static string? sTempoRequesicaoOpcua
            {
                get
                {
                    lock (lockObjectFor_sTempoRequesicaoOpcua)
                    {
                        return _sTempoRequesicaoOpcua;
                    }
                }
                set
                {
                    lock (lockObjectFor_sTempoRequesicaoOpcua)
                    {
                        _sTempoRequesicaoOpcua = value;
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
