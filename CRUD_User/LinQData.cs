using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_User
{
    public class LinQData : IDisposable
    {
        UsuariosDataDataContext UDC;

        public LinQData()
        {
            try
            {
                UDC = new UsuariosDataDataContext();
            }
            catch (Exception ex)
            {

            }
        }

        public void Dispose()
        {
            GC.Collect();
        }

        public bool InsertarLinQ(string usuario, string nickname, string contrasenia, string email)
        {
            try
            {
                if (UDC != null)
                {
                    Usuarios nvouser = new Usuarios();

                    nvouser.Usuario = usuario;
                    nvouser.Nickname = nickname;
                    nvouser.Contraseña = contrasenia;
                    nvouser.Email = email;

                    UDC.Usuarios.InsertOnSubmit(nvouser);

                    UDC.SubmitChanges();

                    return true;
                }

                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificarLinQ(string usuario, string nickname, string contrasenia, string email, int id)
        {
            try
            {
                if (UDC != null)
                {
                    var exist = UDC.Usuarios.FirstOrDefault(x => x.UsuarioId == id);

                    if (exist != null)
                    {
                        exist.Usuario = usuario;
                        exist.Nickname = nickname;
                        exist.Contraseña = contrasenia;
                        exist.Email = email;

                        UDC.SubmitChanges();

                        return true;
                    }
                    else
                        return false;
                    
                }

                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool BorrarLinQ(int id)
        {
            try
            {


                if (UDC != null)
                {
                    var exist = UDC.Usuarios.FirstOrDefault(x => x.UsuarioId == id);

                    if (exist != null)
                    {
                        UDC.Usuarios.DeleteOnSubmit(exist);

                        UDC.SubmitChanges();

                        return true;
                    }
                    else
                        return false;

                }

                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Usuarios> GetUsuarios()
        {
            try
            {
                if (UDC != null)
                {
                    var usuarios = from s in UDC.Usuarios
                                   //where s.UsuarioId > 0
                                   orderby s.UsuarioId descending
                                   select s;
                    if (usuarios != null)
                        return usuarios.ToList();
                    else
                        return null;
                }
                else
                    return null;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
