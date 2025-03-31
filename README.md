# 🤖 **Robô Tupiniquim**  

![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Microsoft Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)
![Microsoft](https://img.shields.io/badge/Microsoft-0078D4?style=for-the-badge&logo=microsoft&logoColor=white)

## 📌 **Introdução**  

O **Robô Tupiniquim** é uma aplicação **ConsoleApp** em **C#** que simula o movimento de robôs em um plano cartesiano. Os robôs podem ser posicionados, receber comandos de movimento (virar ou avançar) e são exibidos no console. O projeto inclui validações para garantir entradas corretas e evitar comportamentos inesperados.  

---

## 🚀 **Funcionalidades**  

✅ **Configuração do Plano Cartesiano:**  
- Define o tamanho do plano (X e Y) com valores entre **1x1** e **20x20**.  
- Valida se as dimensões são números inteiros e dentro do limite.  

✅ **Posicionamento Inicial dos Robôs:**  
- Permite adicionar múltiplos robôs com coordenadas (X, Y) e direção inicial (N, L, S, O).  
- Valida se a posição está dentro dos limites do plano.  

✅ **Comandos de Movimento:**  
- Comandos suportados:  
  - `D`: Virar 90° à direita.  
  - `E`: Virar 90° à esquerda.  
  - `M`: Mover para frente (respeitando os limites do plano).  

✅ **Visualização em Tempo Real:**  
- Exibe o plano cartesiano com símbolos indicando a direção dos robôs:  
  - `^` (Norte), `>` (Leste), `v` (Sul), `<` (Oeste).  
  - Atualiza a posição após a execução de todos os comandos.  

✅ **Validações Rigorosas:**  
- Impede entradas inválidas (caracteres, valores fora do range, direções incorretas).  
- Exibe mensagens claras de erro e instruções para correção.  

✅ **Repetição e Continuidade:**  
- Permite adicionar novos robôs ou reiniciar o programa sem fechar o console.  

---

## 🎮 **Como Funciona?**  

1. **Definição do Plano:**  
   - O usuário insere as dimensões X e Y do plano (ex: `5 5`).  

2. **Posicionamento dos Robôs:**  
   - Para cada robô, são informados:  
     - Coordenadas iniciais (ex: `0 0 N`).  
     - Sequência de comandos (ex: `DMMEM`).  

3. **Execução dos Comandos:**  
   - Os robôs executam os comandos na ordem fornecida, atualizando sua posição e direção.  

4. **Exibição do Resultado:**  
   - O plano é desenhado no console com os robôs em suas posições finais.  
   - Uma tabela mostra detalhes finais (X, Y, Direção) de cada robô.  

5. **Opção de Continuar:**  
   - O usuário pode adicionar mais robôs, reiniciar o plano ou encerrar o programa.  

---

## 💻 Exemplo de Execução:  

![](https://i.imgur.com/6oYH2Ad.gif)

---
# 📝 Regras e Limitações  

## 📏 Valores Máximos do Plano  
- O plano tem um tamanho máximo de **20x20** para evitar sobrecarga no console.  

## 🚫 Comandos Inválidos  
- Comandos inválidos são **ignorados silenciosamente** (não interrompem o fluxo).  

## 📍 Posicionamento  
- Robôs **não podem** ser colocados fora dos limites do plano.  
  - Exemplo: X=5 em um plano **4x4** é inválido.   

# 🔄 Fluxo de Validação  

## 🗺️ Entrada do Plano  
- Dois **números inteiros** separados por espaço.  

### ❌ Erro se:  
- Valores **não forem inteiros**.  
- **X ou Y forem < 1 ou > 20**.  

## 🤖 Entrada da Posição do Robô  
- Três valores: **X, Y, Direção**.  

### ❌ Erro se:  
- **X/Y estiverem fora do plano**.  
- **Direção não for N, L, S ou O**.  

## 🎮 Entrada de Comandos  
- Apenas os caracteres **D, E ou M** são aceitos.
  
---

## 🛠 Como utilizar:
🚀 Passo a Passo

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto

```
dotnet restore
```
4. Em seguida, compile a solução o comando:
```
dotnet build --configuration Release
```
5. Para executar o projeto compilando em tempo real
```
dotnet run --project RoboTupiniquim
```
6. Para executar o arquivo compilado, navegue até a pasta: ./RoboTupiniquim/bin/Release/net8.0/ e execute o arquivo:
```
RoboTupiniquim.exe
```
## ✅ Requisitos
.NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
