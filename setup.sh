#!/bin/sh
# =============================================================
# AI Code Review — Setup
# Execute uma vez por clone/máquina para ativar o hook.
#
# Uso:
#   sh setup.sh
# =============================================================

set -e

# Verifica se está num repo git
if ! git rev-parse --git-dir > /dev/null 2>&1; then
  echo "  ✖  Não é um repositório git. Execute na raiz do projeto."
  exit 1
fi

# Instala dependências do .ai-review/ se ainda não existirem
if [ ! -d ".ai-review/node_modules" ]; then
  echo "  →  Instalando dependências (.ai-review/node_modules)..."
  (cd .ai-review && npm install --silent)
  echo "  ✔  Dependências instaladas."
else
  echo "  ✔  Dependências já instaladas."
fi

# Aponta o git para a pasta .githooks/
git config core.hooksPath .githooks
echo "  ✔  git config core.hooksPath = .githooks"

echo ""
echo "  Pronto! O hook de revisão de código está ativo neste repositório."
echo "  Use 'git push --no-verify' para pular a revisão quando necessário."
