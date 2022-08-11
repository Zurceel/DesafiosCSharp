//Console.WriteLine("Digite a sua idade");
//int idade = Convert.ToInt32(Console.ReadLine());

//if (idade <= 59)
//{
//	Console.WriteLine("Você ainda não tem direto a tirar o cartão idoso da prefeitura");
//	int anosfaltantes = 60 - idade;
//	int diasfaltantes = anosfaltantes * 365;
//	Console.WriteLine("Faltam ainda " + anosfaltantes + "anos para tirar o cartão");
//	Console.WriteLine("Faltam ainda " + diasfaltantes + "dias aproximadamente para tirar o cartão");
//	idade++;
//	int umanomaisvelho = idade++;
//	diasfaltantes = (60 - umanomaisvelho) * 365;
//	Console.WriteLine("Faltaria " + diasfaltantes + "dias aproximadamente para tirar o seu cartão se você tivesse um ano a mais");
//}
//else
//{
//	Console.WriteLine("Você tem direto a tirar o cartão idoso da prefeitura");
//}

string nomejogador;

Console.WriteLine("Bem-vindos ao toneio de Poker!");

nomejogador = Console.ReadLine().ToString();

bool validacaojogador;

switch (nomejogador)
{
	case "Gabriel":
	case "Geovanna":
	case "Gael":
	case "André":
		Console.WriteLine("Jogador autorizado para o torneio");
		validacaojogador = true;
		break;
	default:
		Console.WriteLine("Jogador não autorizado para o torneio");
		validacaojogador = false;
		break;
}

if(validacaojogador)
{
	Console.WriteLine("Quantas vitórias você conquistou?");
		int vitorias = Convert.ToInt32(Console.ReadLine());
	int pontuacaoatual = VerificarPontuacao(vitorias);
	Console.WriteLine("Você possui " + pontuacaoatual.ToString() + " pontos no torneio");
	int pontuacaonova = BonificarParticipacao(pontuacaoatual);
	Console.WriteLine("Parabéns, você ganhou 1 ponto de bônus. Agora sua pontuação é " + pontuacaonova.ToString());
}


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