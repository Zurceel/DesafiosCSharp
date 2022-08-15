string nomejogador;

Console.WriteLine("Bem-vindos ao toneio de Poker!");

ExemploDoWhile();

//Console.WriteLine("Qual o nome do jogador?");

//nomejogador = Console.ReadLine().ToString();

//bool validacaojogador;

//switch (nomejogador)
//{
//	case "Gabriel":
//	case "Geovanna":
//	case "Gael":
//	case "André":
//		Console.WriteLine("Jogador autorizado para o torneio");
//		validacaojogador = true;
//		break;
//	default:
//		Console.WriteLine("Jogador não autorizado para o torneio");
//		validacaojogador = false;
//		break;
//}

//if(validacaojogador)
//{
//	Console.WriteLine("Quantas vitórias você conquistou?");
//		int vitorias = Convert.ToInt32(Console.ReadLine());
//	int pontuacaoatual = VerificarPontuacao(vitorias);
//	Console.WriteLine("Você possui " + pontuacaoatual.ToString() + " pontos no torneio");
//	int pontuacaonova = BonificarParticipacao(pontuacaoatual);
//	Console.WriteLine("Parabéns, você ganhou 1 ponto de bônus. Agora sua pontuação é " + pontuacaonova.ToString());
//}


// metodo de verificacao do jogador
int VerificarPontuacao (int vitorias)
{
	const int fatorvitoria = 3;

	int pontuacao = fatorvitoria * vitorias;

	return pontuacao;
}

// metodo de bonificacao de particiapação
int BonificarParticipacao(int pontuacaoatual)
{
	int pontuacaonova = pontuacaoatual;
	pontuacaoatual++;

	return pontuacaoatual;
}

void ExemploForEach()
{
	string[] jogadores = { "Gabriel", "Geovanna", "Gael", "André" };

	foreach (string jogador in jogadores)
	{
		Console.WriteLine("Bem-vindo as quartas de finais " + jogador);
	}
}


void ExemploFor()
{
	string[] jogadores = { "Gabriel", "Geovanna", "Gael", "André" };

	for(int contajoador =0; contajoador < 4; contajoador++)
	{
		Console.WriteLine("Bem-vindo as quartas de finais " + jogadores[contajoador]);
	}
}

void ExemploWhile()
{
	Console.WriteLine("Qual a sua pontuação atual?");
	int pontuacaojogador = Convert.ToInt32(Console.ReadLine());

	if (pontuacaojogador < 27)
	{

		while (pontuacaojogador < 27)
		{
			Console.WriteLine("Jogando!");
			Console.WriteLine("Você ganhou? (S/N)");
			string ganhou = Console.ReadLine();
			if (ganhou == "S")
			{
				pontuacaojogador = pontuacaojogador + 3;
			}
			else
			{
				Console.WriteLine("Infelizmente você está fora do torneio");
				break;
			}
		}
		Console.WriteLine("Você já está nas quartas de final!");
	}
	else
	{
		Console.WriteLine("Você já está nas quartas de final!");
	}
}

void ExemploDoWhile()
{
	string mensagem = "";
	try
	{
		Console.WriteLine("Qual a sua pontuação atual?");
		int pontuacaojogador = Convert.ToInt32(Console.ReadLine());

		if (pontuacaojogador < 27)
		{

			do
			{
				Console.WriteLine("Jogando!");
				Console.WriteLine("Você ganhou? (S/N)");
				string ganhou = Console.ReadLine();
				if (ganhou == "S")
				{
					pontuacaojogador = pontuacaojogador + 3;
				}
				else
				{
					mensagem = ("Infelizmente você está fora do torneio");
					break;

				}
			} while (pontuacaojogador < 27);
			mensagem = ("Você já está nas quartas de final!");
		}
		else
		{
			mensagem = ("Você já está nas quartas de final!");
		}
	}
	catch (Exception ex)
	{
		mensagem = ("Aconteceu o seguinte erro: " + ex.Message);
	}
	finally
	{
		Console.WriteLine(mensagem);
	}
}