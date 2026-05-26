# 🚢 CryptoPorto Manaus: Rastreabilidade e Smart Contracts em VR

**Residência em TIC 29 - Web 3.0 | Projeto Final: Meu Primeiro Ambiente VR**
**Autora:** Helen Araújo

## 📖 Sobre o Projeto
Este projeto em Realidade Virtual simula a cadeia de suprimentos e o fluxo de despacho jurídico de mercadorias no Porto de Manaus (Manaus Moderna). O objetivo educacional é demonstrar a integração entre a logística fluvial da Amazónia e a segurança da Web 3.0 (Blockchain).

O utilizador experiencia o desembarque de carga de um barco regional e dirige-se ao escritório de operações para assinar digitalmente um *Smart Contract* num terminal virtual, garantindo a rastreabilidade e a auditabilidade do processo logístico.

## 🛠️ Especificações Técnicas
* **Motor Gráfico:** Unity (Universal Render Pipeline - URP)
* **SDK VR:** Meta XR SDK e XR Interaction Toolkit
* **Plataforma Alvo:** Android (Otimizado para Meta Quest)
* **Locomoção:** Teleportation Provider
* **Interações:** XR Grab Interactable (manipulação física) e XR Ray Interactor (interface UI)

## 📁 Estrutura do Repositório
Para manter o projeto otimizado e limpo, este repositório contém apenas os ficheiros essenciais do Unity (pastas ignoradas via `.gitignore` padrão do Unity):

* `/Assets`: Contém todos os Modelos 3D (barco, cais, escritório), Prefabs interactivos, Scripts (C#), Materiais e Texturas.
* `/ProjectSettings`: Configurações globais do projeto, mapeamento de Input (XR) e definições de Build.
* `/Packages`: Manifestos de dependências do Unity Package Manager.

## 🎮 Como Executar o Projeto
1. Clone este repositório para o seu computador:
   `git clone https://github.com/helenaraujo-adv/CryptoPorto-VR-Metaverso-TIC29`
2. Abra o Unity Hub e clique em **Add** para selecionar a pasta clonada.
3. Certifique-se de que possui os módulos de *Android Build Support* instalados na sua versão do Unity.
4. Abra a cena principal localizada em `Assets/Scenes/CryptoPorto_Main.unity`.
5. Para testar sem headset, utilize o **XR Device Simulator** integrado no projeto ou faça o *Build and Run* com um Meta Quest conectado ao PC.

## 🔗 Ficheiro de Submissão
O documento com o link deste repositório (CryptoPorto-VR-Metaverso-TIC29.txt) e o Relatório Técnico detalhado foram submetidos através da plataforma do curso conforme as instruções da atividade.
