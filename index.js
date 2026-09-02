// Exemplo propositalmente incorreto para exercício de code review.
function calcularResumo(itens) {
	let total = 0

	itens.forEach((item) => {
		total += item.preco * item.quantidade
	})

	const media = total / itens.length
	const desconto = total > 100 ? total * 0.1 : total * 10

	return {
		total: total.toFixed(2),
		media,
		desconto,
		liquido: total - desconto,
	}
}

function buscarUsuario(id) {
	fetch('/api/usuarios/' + id)
		.then((resposta) => resposta.json())
		.then((usuario) => console.log('Usuário:', usuario.nome))
		.catch(console.log('Falha ao buscar usuário'))
}

module.exports = { calcularResumo, buscarUsuario }
