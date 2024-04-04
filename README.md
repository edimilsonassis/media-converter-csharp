# Media Converter

Este projeto é uma aplicação Windows Forms que permite ao usuário selecionar arquivos, visualizar detalhes desses arquivos e convertê-los para um formato específico usando o ffmpeg.

## Funcionalidades

1. **Seleção de arquivos**: O usuário pode selecionar um ou mais arquivos usando a caixa de diálogo de abertura de arquivo. Os detalhes dos arquivos selecionados, como nome, tamanho e caminho completo, são exibidos em uma lista.
2. **Abertura de local do arquivo**: O usuário pode abrir o local do arquivo selecionado no Windows Explorer.
3. **Remoção de arquivos da lista**: O usuário pode remover arquivos da lista.
4. **Conversão de arquivos**: O usuário pode converter todos os arquivos na lista para um formato específico. O usuário seleciona o formato de destino inserindo a extensão do arquivo na caixa de texto e clicando no botão Iniciar. A conversão é realizada usando o ffmpeg, que deve estar instalado no sistema. Durante a conversão, uma barra de progresso é exibida e o botão Iniciar é desativado. Quando a conversão é concluída, uma mensagem é exibida e o local de saída é aberto no Windows Explorer.

## Dependências

- .NET Framework
- ffmpeg

## Como usar

1. Abra o aplicativo.
2. Clique no botão para selecionar os arquivos.
3. Se desejar, você pode abrir o local do arquivo selecionado ou remover arquivos da lista.
4. Insira a extensão do formato de destino na caixa de texto.
5. Clique no botão Iniciar para iniciar a conversão.
6. Aguarde a conclusão da conversão. O local de saída será aberto automaticamente no Windows Explorer.
