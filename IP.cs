using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipv4
{
    class IP
    {
        private byte ip_1, ip_2, ip_3, ip_4;

        public void Set(byte first, byte second, byte third, byte fouth)
        {
            ip_1 = first;
            ip_2 = second;
            ip_3 = third;
            ip_4 = fouth;
        }

        public void Next()
        {
            if (ip_4 < 255)
            {
                ip_4++;
            }
            else
            {
                if (ip_3 < 255)
                {
                    ip_3++;
                    ip_4 = 0;
                }
                else
                {
                    if (ip_2 < 255)
                    {
                        ip_2++;
                        ip_3 = 0;
                        ip_4 = 0;
                    }
                    else
                    {
                        if (ip_1 < 255)
                        {
                            ip_1++;
                            ip_2 = 0;
                            ip_3 = 0;
                            ip_4 = 0;
                        }
                    }
                }
            }
        }

        public byte Get_1()
        {
            return ip_1;
        }


        public byte Get_2()
        {
            return ip_2;
        }


        public byte Get_3()
        {
            return ip_3;
        }


        public byte Get_4()
        {
            return ip_4;
        }

        public bool IsLess(IP ip)
        {
            if (Get_1() > ip.Get_1())
            {
                return false;
            }
            else
            {
                if (Get_1() == ip.Get_1())
                {
                    if (Get_2() > ip.Get_2())
                    {
                        return false;
                    }
                    else
                    {
                        if (Get_2() == ip.Get_2())
                        {
                            if (Get_3() > ip.Get_3())
                            {
                                return false;
                            }
                            else
                            {
                                if (Get_3() == ip.Get_3())
                                {
                                    if (Get_4() >= ip.Get_4())
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        return true;
                                    }
                                }
                                else
                                {
                                    return true;
                                }
                            }
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
