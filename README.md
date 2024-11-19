<h1>Documentação - Aplicação Web com Entity Framework Core</h1>
        <p>Este projeto é uma aplicação web que utiliza o <strong>Entity Framework Core</strong> para gerenciar o banco de dados. Ele está configurado para usar <strong>SQL Server</strong> como o provedor de banco de dados.</p>
        <p> Observação: Lembre-se de clonar o projeto.</p>

  <h2>Requisitos</h2>
  <p>Certifique-se de que os seguintes requisitos estão atendidos antes de executar o projeto:</p>
  <h3>1. SDK do .NET</h3>
  <ul>
      <li><strong>Versão mínima:</strong> Compatível com o projeto. <a href="https://dotnet.microsoft.com/download" target="_blank">Baixe o SDK do .NET</a>.</li>
      <li>Verifique a instalação com:
          <pre><code>dotnet --version</code></pre>
      </li>
  </ul>

  <h3>2. SQL Server</h3>
  <p>Tenha um servidor SQL Server disponível. Configure a <em>connection string</em> no arquivo <code>appsettings.json</code>.</p>

  <h3>3. Pacotes Necessários</h3>
  <p>Os pacotes do Entity Framework Core utilizados no projeto são:</p>
  <ul>
      <li>Microsoft.EntityFrameworkCore</li>
      <li>Microsoft.EntityFrameworkCore.Design</li>
      <li>Microsoft.EntityFrameworkCore.SqlServer</li>
      <li>Microsoft.EntityFrameworkCore.Tools</li>
      <li>Microsoft.VisualStudio.Web.CodeGeneration.Design</li>
      <li>Microsoft.EntityFrameworkCore.CodeGeneration.Design</li>
  </ul>
  <p>Para instalar manualmente, primeiramente tranha instalado o .NET SDK, logo em seguida, entre no projeto, abra um novo terminal e execute os seguintes comandos:</p>
  <pre><code>
cd .\DigitalLib\
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.CodeGeneration.Design
        </code></pre>

  <h2>Configuração do Banco de Dados</h2>
  <h3>1. Criar o Banco de Dados</h3>
  <ol>
      <li><strong>Adicione uma Migração Inicial:</strong>
        <pre><code>dotnet ef migrations add "Nome da migração"</code></pre>
      </li>
      <li><strong>Atualize o Banco de Dados:</strong>
          <pre><code>dotnet ef database update</code></pre>
          <p>Isso criará o banco de dados definido na <em>connection string</em> do arquivo <code>appsettings.json</code>.</p>
      </li>
  </ol>

  <h3>2. Resetar o Banco de Dados</h3>
  <ol>
      <li><strong>Apague o Banco de Dados Existente:</strong>
          <pre><code>dotnet ef database drop</code></pre>
          <p>Confirme a exclusão quando solicitado.</p>
      </li>
      <li><strong>Recrie o Banco de Dados:</strong>
          <pre><code>dotnet ef database update</code></pre>
      </li>
  </ol>

  <h2>Comandos Úteis</h2>
  <ul>
      <li><strong>Criar uma nova migração:</strong>
          <pre><code>dotnet ef migrations add NomeDaMigracao</code></pre>
      </li>
      <li><strong>Aplicar migrações ao banco de dados:</strong>
          <pre><code>dotnet ef database update</code></pre>
      </li>
      <li><strong>Excluir o banco de dados:</strong>
          <pre><code>dotnet ef database drop</code></pre>
      </li>
      <li><strong>Listar migrações existentes:</strong>
          <pre><code>dotnet ef migrations list</code></pre>
      </li>
  </ul>

  <h2>Notas Importantes</h2>
  <p><strong>Ambiente de Produção:</strong> Tenha cuidado ao resetar o banco de dados em produção. Faça backups antes de qualquer operação que possa apagar dados.</p>
  <p><strong>Ferramentas do EF CLI:</strong> Certifique-se de que as ferramentas do Entity Framework Core CLI estão instaladas:</p>
  <pre><code>dotnet tool install --global dotnet-ef</code></pre>
</div>
</body>
