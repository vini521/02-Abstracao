/*Instanciar a classe e os nomes */

using _02_Abstração;
//Pet pet1 = new Pet("Taleco", "Pit bull", 7);

//Console.WriteLine("O nome do seu cachorro é " + pet1.Nome + " a sua  raça é: " + pet1.Raca + " e sua iadade é " + pet1.Idade + "anos de idade");
//pet1.Alimentar();

//Console.ReadKey();


//using _02_Abstração;
//Livro livro1 = new Livro("Perci Jackson", "Artur Conon", "Seleta", 2013);
//Livro livro2 = new Livro("Narnia", "Cauã Ferreira", "Editmais", 2009);
//Livro livro3 = new Livro("Sniper Americano", "Cris kile", "USAedi", 2014);

//Console.WriteLine($"O Livro 1 é {livro1.Titulo}, seu autor é {livro1.Autor}, sua editora é {livro1.Editora} e foi lançado em {livro1.Ano}");
//Console.WriteLine($"O Livro 2 é {livro2.Titulo}, seu autor é {livro2.Autor}, sua editora é {livro2.Editora} e foi lançado em {livro2.Ano}");
//Console.WriteLine($"O Livro 3 é {livro3.Titulo}, seu autor é {livro3.Autor}, sua editora é {livro3.Editora} e foi lançado em {livro3.Ano}");

//Console.ReadKey();
//Aluno a1 = new Aluno(1978, "Vinicius de Santis", new DateOnly(2007,08,10), "vinicius.santis@gmail.com");
//Aluno a2 = new Aluno(1979, "Livia Maria Rodrigues", new DateOnly(2007,11,20), "livia.sil@gmail.com");
//Aluno a3 = new Aluno(1950, "Thigos Togo", new DateOnly(2005,12,30), "Thigas.telo@gmail.com");

//Console.WriteLine($"O RM do primeiro aluno é {a1.Rm};\nSeu nome é {a1.Nome};\nSua data de nascimento é {a1.Data};\nSeu email é {a1.Email};");
//Console.WriteLine($"\nO RM do segundo aluno é {a2.Rm};\nSeu nome é {a2.Nome};\nSua data de nascimento é {a2.Data};\nSeu email é {a2.Email};");
//Console.WriteLine($"\nO RM do terceiro aluno é {a3.Rm};\nSeu nome é {a3.Nome};\nSua data de nascimento é {a3.Data};\nSeu email é {a3.Email};");

//Console.ReadKey();

//Produto p1 = new Produto(5587, "X-salada", 23.00, 50);
//Produto p2 = new Produto(5587, "X-baon", 28.00, 300);
//Produto p3 = new Produto(5587, "X-tudo", 38.00, 1000);

//Console.WriteLine($"O codigo do primeiro produto é {p1.Codigo}\nSeu nome é {p1.Nome}\nSeu preço é {p1.Preco}");
//p1.ValorEstoque();

//Console.WriteLine($"\nO codigo do primeiro produto é {p2.Codigo}\nSeu nome é {p2.Nome}\nSeu preço é {p2.Preco}");
//p2.ValorEstoque();

//Console.WriteLine($"\nO codigo do primeiro produto é {p3.Codigo}\nSeu nome é {p3.Nome}\nSeu preço é {p3.Preco}");
//p3.ValorEstoque();

//Console.ReadKey();

Carro c1 = new Carro("Chevrolet", "Omega CD", 215, 105);
Carro c2 = new Carro("Chevrolet", "Brasila Ls", 129, 19);
Carro c3 = new Carro("Chevrolet", "D-20", 123, 13);

Console.WriteLine($"A marca do carro é {c1.Marca};\nSeu modelo é {c1.Modelo}");
c1.velocidademx();
c1.Desacelerar();

Console.WriteLine($"\nA marca do carro é {c2.Marca};\nSeu modelo é {c2.Modelo}");
c2.velocidademx();
c2.Desacelerar();

Console.WriteLine($"\nA marca do carro é {c3.Marca};\nSeu modelo é {c3.Modelo}");
c3.velocidademx();
c3.Desacelerar();

Console.ReadKey();