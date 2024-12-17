using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Entrada.ViewModel.Variaveis
{
    class GVRL
    {
        public class Parametros
        {
            private static object lockObjectFor_sIp_bloco_de_rede = new object();
            private static string? _sIp_bloco_de_rede;
            public static string? sIp_bloco_de_rede
            {
                get
                {
                    lock (lockObjectFor_sIp_bloco_de_rede)
                    {
                        return _sIp_bloco_de_rede;
                    }
                }
                set
                {
                    lock (lockObjectFor_sIp_bloco_de_rede)
                    {
                        _sIp_bloco_de_rede = value;
                    }
                }
            }
            private static object lockObjectFor_sUsuario = new object();
            private static string _sUsuario;
            public static string sUsuario
            {
                get
                {
                    lock (lockObjectFor_sUsuario)
                    {
                        return _sUsuario;
                    }
                }
                set
                {
                    lock (lockObjectFor_sUsuario)
                    {
                        _sUsuario = value;
                    }
                }
            }
            private static object lockObjectFor_sSenha = new object();
            private static string _sSenha;
            public static string sSenha
            {
                get
                {
                    lock (lockObjectFor_sSenha)
                    {
                        return _sSenha;
                    }
                }
                set
                {
                    lock (lockObjectFor_sSenha)
                    {
                        _sSenha = value;
                    }
                }
            }
            private static object lockObjectFor_sUrl_Camera = new object();
            private static string _sUrl_Camera;
            public static string sUrl_Camera
            {
                get
                {
                    lock (lockObjectFor_sUrl_Camera)
                    {
                        return _sUrl_Camera;
                    }
                }
                set
                {
                    lock (lockObjectFor_sUrl_Camera)
                    {
                        _sUrl_Camera = value;
                    }
                }
            }
            private static object lockObjectFor_sUrl_Opcua = new object();
            private static string _sUrl_Opcua;
            public static string sUrl_Opcua
            {
                get
                {
                    lock (lockObjectFor_sUrl_Opcua)
                    {
                        return _sUrl_Opcua;
                    }
                }
                set
                {
                    lock (lockObjectFor_sUrl_Opcua)
                    {
                        _sUrl_Opcua = value;
                    }
                }
            }
            private static object lockObjectFor_sDiretorio_de_Imagens = new object();
            private static string _sDiretorio_de_Imagens;
            public static string sDiretorio_de_Imagens
            {
                get
                {
                    lock (lockObjectFor_sDiretorio_de_Imagens)
                    {
                        return _sDiretorio_de_Imagens;
                    }
                }
                set
                {
                    lock (lockObjectFor_sDiretorio_de_Imagens)
                    {
                        _sDiretorio_de_Imagens = value;
                    }
                }
            }
            private static object lockObjectFor_sPeriodo_de_Descarte_Imagens = new object();
            private static string _sPeriodo_de_Descarte_Imagens;
            public static string sPeriodo_de_Descarte_Imagens
            {
                get
                {
                    lock (lockObjectFor_sPeriodo_de_Descarte_Imagens)
                    {
                        return _sPeriodo_de_Descarte_Imagens;
                    }
                }
                set
                {
                    lock (lockObjectFor_sPeriodo_de_Descarte_Imagens)
                    {
                        _sPeriodo_de_Descarte_Imagens = value;
                    }
                }
            }
        }
    }
}
