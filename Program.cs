namespace ContaTasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("*** Benvenuti dentro l'ennesimo incubo della tassomonologia!!! ***");
                Console.WriteLine();

                // NOME
                bool controllo = true;
                string nome = "";

                while (controllo)
                {
                    Console.WriteLine($"Inserisci il tuo nome:");
                    nome = Console.ReadLine();
                    if (nome.Length < 2)
                    {
                        Console.WriteLine("Questo nome non esiste, inseriscine un' altro");
                        Console.WriteLine();
                        GestisciScelta();
                    }
                    else
                    {
                        controllo = false;
                    }
                }


                // COGNOME

                controllo = true;
                string cognome = "";

                while (controllo)
                {
                    Console.WriteLine($"Inserisci il tuo cognome:");
                    cognome = Console.ReadLine();
                    if (cognome.Length < 2)
                    {
                        Console.WriteLine("Questo cognome non esiste, inseriscine un' altro");
                        Console.WriteLine();
                        GestisciScelta();
                    }
                    else
                    {
                        controllo = false;
                    }


                    // DATA DI NASCITA

                    Console.Clear();

                    Console.WriteLine("Inserisci la data di nascita; (GG/MM/AAAA):");

                    // GIORNO

                    controllo = true;
                    string giornoNascita = "";

                    while (controllo)
                    {
                        Console.Write("Inserisci il giorno: ");
                        giornoNascita = Console.ReadLine();
                        if (giornoNascita.Length != 2)
                        {
                            Console.WriteLine("Inserisci nel formato giusto");
                            Console.WriteLine();
                            GestisciScelta();

                        }
                        else if (int.Parse(giornoNascita) <= 0 || int.Parse(giornoNascita) > 31)
                        {
                            Console.WriteLine("Questo giorno non esiste");
                            Console.WriteLine();
                            GestisciScelta();

                        }
                        else
                        {
                            controllo = false;
                        }
                    }




                    // MESE

                    controllo = true;
                    string meseNascita = "";

                    while (controllo)
                    {
                        Console.Write("Inserisci il mese: ");
                        meseNascita = Console.ReadLine();
                        if (meseNascita.ToString().Length != 2)
                        {
                            Console.WriteLine("Inserisci nel formato giusto");
                            Console.WriteLine();
                            GestisciScelta();

                        }
                        else if (int.Parse(meseNascita) <= 0 || int.Parse(meseNascita) > 12)
                        {
                            Console.WriteLine("Questo mese non esiste");
                            Console.WriteLine();
                            GestisciScelta();

                        }
                        else
                        {
                            controllo = false;
                        }
                    }

                    // ANNO

                    controllo = true;
                    string annoNascita = "";

                    while (controllo)
                    {
                        Console.Write("Inserisci l'anno: ");
                        annoNascita = Console.ReadLine();
                        if (annoNascita.ToString().Length != 4)
                        {
                            Console.WriteLine("Inserisci nel formato giusto");
                            Console.WriteLine();
                            GestisciScelta();

                        }
                        else if (int.Parse(annoNascita) > 2024)
                        {
                            Console.WriteLine("Ancora devi nascèèèèèèè!!!");
                            Console.WriteLine();
                            GestisciScelta();
                        }
                        else
                        {
                            controllo = false;
                        }
                    }


                    // CODICE FISCALE
                    Console.Clear();
                    controllo = true;
                    string codiceFiscale = "";

                    while (controllo)
                    {
                        Console.WriteLine($"Inserisci il tuo codice fiscale:");
                        codiceFiscale = Console.ReadLine();
                        if (codiceFiscale.Length != 16)
                        {
                            Console.WriteLine("troppi pochi caratteri");
                            Console.WriteLine();
                            GestisciScelta();
                        }
                        else
                        {
                            controllo = false;
                        }
                    }

                    // GENERE
                    Console.Clear();
                    controllo = true;
                    string genere = "";

                    while (controllo)
                    {
                        Console.WriteLine("Digita M per Maschio, F per Femmina, A per Altro");
                        genere = Console.ReadLine().ToLower();

                        if (genere.ToLower() != "m" && genere.ToLower() != "f" && genere.ToLower() != "a")
                        {
                            Console.WriteLine("Il tuo genere non esiste");
                            Console.WriteLine();
                            GestisciScelta();

                        }
                        else
                        {
                            controllo = false;
                        }
                    }

                    // RESIDENZA
                    Console.Clear();
                    controllo = true;
                    string residenza = "";
                    while (controllo)
                    {
                        Console.WriteLine($"Inserisci la tua residenza:");
                        residenza = Console.ReadLine();
                        if (residenza.Length > 30)
                        {
                            Console.WriteLine("Non esistono paesi con questo nome");
                            Console.WriteLine();
                            GestisciScelta();
                        }
                        else
                        {
                            controllo = false;
                        }
                    }

                    //REDDITO
                    Console.Clear();
                    controllo = true;
                    double reddito = 0;

                    while (controllo)
                    {
                        Console.WriteLine($"Inserisci il tuo reddito:");
                        reddito = double.Parse(Console.ReadLine());

                        User contribuente1 = new User(nome, cognome, giornoNascita, meseNascita, annoNascita, codiceFiscale, genere, residenza, reddito);

                        if (reddito > 0)
                        {
                            if (contribuente1.Reddito > 0 && contribuente1.Reddito <= 15000)
                            {
                                contribuente1.TaxCalc(0, 23, 0);
                            }
                            else if (contribuente1.Reddito >= 15001 && contribuente1.Reddito <= 28000)
                            {
                                contribuente1.TaxCalc(15001, 27, 3450);
                            }
                            else if (contribuente1.Reddito >= 28001 && contribuente1.Reddito <= 55000)
                            {
                                contribuente1.TaxCalc(28001, 38, 6960);
                            }
                            else if (contribuente1.Reddito >= 55001 && contribuente1.Reddito <= 75000)
                            {
                                contribuente1.TaxCalc(55001, 41, 17220);
                            }
                            else
                            {
                                contribuente1.TaxCalc(75000, 43, 25420);
                            }

                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Ecco tutti i tuoi dati");
                            Console.WriteLine();
                            contribuente1.ShowInfo();

                        }
                        else
                        {
                            Console.WriteLine("Le tasse si pagano su redditi maggiori a 0");
                            GestisciScelta();
                        }
                    }

                    

                    
                }

                // METHOD OF CHOICE

                static void GestisciScelta()
                {
                    Console.WriteLine("Digita <Y> se vuoi reinserire o <N> se vuoi uscire dall'applicazione");
                    string scelta = Console.ReadLine().ToLower();

                    if (scelta != "y" && scelta != "n")
                    {
                        Console.WriteLine("Questo comando non esiste");
                        GestisciScelta(); 
                    }
                    else if (scelta == "n")
                    {
                        Console.WriteLine("Arrivederci");
                        Environment.Exit(0);
                    }
                }








            }
        }

        class User
        {
            //FIELDS

            string _nome;
            string _cognome;
            string _giornoNascita;
            string _meseNascita;
            string _annoNascita;
            string _codFiscale;
            string _genere;
            string _residenza;
            double _reddito;

            // PROPERTIES

            public string Nome
            {
                get { return _nome; }
                set { _nome = value; }
            }

            public string Cognome
            {
                get { return _cognome; }
                set { _cognome = value; }
            }

            public string GiornoNascita
            {
                get { return _giornoNascita; }
                set { _giornoNascita = value; }
            }

            public string MeseNascita
            {
                get { return _meseNascita; }
                set { _meseNascita = value; }
            }

            public string AnnoNascita
            {
                get { return _annoNascita; }
                set { _annoNascita = value; }
            }

            public string CodiceFiscale
            {
                get{ return _codFiscale;}
                set{_codFiscale = value;}
            }

            public string Genere
            {
                get{ return _genere;}
                set{ _genere = value; }
            }

            public string Residenza
            {
                get { return _residenza; }
                set { _residenza = value; }
            }

            public double Reddito
            {
                get { return _reddito; }
                set { _reddito = value; }
            }        
                        
                   
               
            

            public double TotTax { get; set; }


            // COSTRUCTOR


            public User(string nome, string cognome, string giornoNascita, string meseNascita, string annoNascita, string codFiscale, string genere, string residenza, double reddito)
            {
                Nome = nome;
                Cognome = cognome;
                GiornoNascita = giornoNascita;
                MeseNascita = meseNascita;
                AnnoNascita = annoNascita;
                CodiceFiscale = codFiscale;
                Genere = genere;
                Residenza = residenza;
                Reddito = reddito;
            }

            // METHODS

            public void TaxCalc(int rangeMin, int aliquota, int taxExec)
            {
                double eccedenza = Reddito - rangeMin;
                double tax = eccedenza * aliquota / 100;
                TotTax = tax + taxExec;

            }



            public void ShowInfo()
            {
                Console.WriteLine();
                Console.WriteLine($"Contribuente: {char.ToUpper(Nome[0])}{Nome.Substring(1).ToLower()} {char.ToUpper(Cognome[0])}{Cognome.Substring(1).ToLower()}");

                Console.WriteLine();
                if (Genere == "m")
                {
                    Console.WriteLine($"Nato: {GiornoNascita} / {MeseNascita} / {AnnoNascita}");
                }
                else if (Genere == "f")
                {
                    Console.WriteLine($"Nata: {GiornoNascita} / {MeseNascita} / {AnnoNascita}");
                }
                else if (Genere == "a")
                {
                    Console.WriteLine($"Natae: {GiornoNascita} / {MeseNascita} / {AnnoNascita}");
                }
                Console.WriteLine();
                Console.WriteLine($"Residente in: {char.ToUpper(Residenza[0])}{Residenza.Substring(1).ToLower()}");
                Console.WriteLine();
                Console.WriteLine($"Codice fiscale: {CodiceFiscale}");
                Console.WriteLine();
                Console.WriteLine($"Reddito dichiarato: {Reddito}");
                Console.WriteLine();
                Console.WriteLine($"IMPOSTA DA VERSARE: {TotTax}");
            }
        }
    }
 }
