@echo off
REM =============================================================
REM AI Code Review — Setup
REM Execute uma vez por clone/maquina para ativar o hook.
REM
REM Uso:
REM   setup.cmd
REM =============================================================

REM Verifica se está num repo git
git rev-parse --git-dir >nul 2>&1
if errorlevel 1 (
  echo   X  Nao e um repositorio git. Execute na raiz do projeto.
  exit /b 1
)

REM Instala dependencias do .ai-review/ se ainda nao existirem
if not exist ".ai-review\node_modules\" (
  echo   ^>  Instalando dependencias ^(.ai-review\node_modules^)...
  pushd .ai-review
  npm install --silent
  popd
  echo   OK  Dependencias instaladas.
) else (
  echo   OK  Dependencias ja instaladas.
)

REM Aponta o git para a pasta .githooks/
git config core.hooksPath .githooks
echo   OK  git config core.hooksPath = .githooks

echo.
echo   Pronto! O hook de revisao de codigo esta ativo neste repositorio.
echo   Use "git push --no-verify" para pular a revisao quando necessario.
