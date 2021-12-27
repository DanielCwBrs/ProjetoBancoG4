get set:
serve para gerenciar o acesso a um atibuto conforme definido pelo programador, sendo get para retornar um valor e set para enviar um valor ao atributo;
exemplo: digamos que temos uma Classe Pessoa, esta classe pessoa é composta por atributos como nome; agora digamos que essa classe pessoa seja do tipo privado, 
onde o usuario não consiga modifica-lo livrimente, então utilizaremos o sistema get e set para que seja possivel que o usuario edite somente o que o programador deseja!

na prática:

private string nome;

// Get e Set

public string Nome
{
	get{return nome;}	// Aqui o get faz o trabalho de retornar o "nome" ou qualquer outro dado desse usuario que esta guardado no banco de dados, 
						//ou seja, se o usuario quer saber o nome dessa pessoa, ela tera acesso, pois atribuimos o nome como public e adicionamos o get;
						//caso não queira que o usuario saiba o nome desta pessoa, basta remover o get. 
	
	set{nome=value}		//O set faz o trabalho de receber um valor do usuario, caso ele deseje guardar um nome dentro do sistema, ele pode atraves da variavel value.
}