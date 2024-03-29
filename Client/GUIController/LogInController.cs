﻿using Client.Exceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIController
{
  public   class LogInController
    {
        internal void Login(FrmLogIn frmLogIn)
        {
            Korisnik k = new Korisnik();
            k.KorisnickoIme = frmLogIn.TxtKorisnickoIme.Text;
            k.Lozinka = frmLogIn.TxtLozinka.Text;
            try
            {
                Communication.Instance.Connect();
                //  k = Communication.Instance.LogIn(k);
                k = Communication.Instance.PosaljiZahtevVratiRezultat<Korisnik>(Common.Operation.LogIN, k);
               
                    frmLogIn.DialogResult = DialogResult.OK;
                    MessageBox.Show($"Dobrodošli {k.Ime} {k.Prezime}");
            }catch(SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(SocketException  ex)
            {
                MessageBox.Show("Greška pri konektovanju na server, server nije pokrenut!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }
    }
}
