<?php
class bd
{
    public static function ConectarBanco()
    {
        require_once '../models/Config.php';

        // Criação da conexão
        $conn = new mysqli(connection::$host, connection::$user, connection::$password, connection::$database);

        // Verifica se houve erro na conexão
        if ($conn->connect_error) {
            die("Erro na conexão: " . $conn->connect_error);
        }

        // Define o charset para evitar problemas com caracteres especiais
        $conn->set_charset("utf8mb4");

        return $conn;
    }
}

class Tratamentos
{

}

class Exibir
{
    public static function exibirTiposProd($tipos)
    {
        foreach ($tipos as $tipo) {
            echo '<form method="post" action="../Views/MenuPedidos.php">';
            echo '<input type="hidden" name="tipo" value="' . htmlspecialchars($tipo['TB_TIPO_PRODUTO_DESC']) . '">';
            echo '<input type="submit" name="btntipo" value="' . htmlspecialchars($tipo['TB_TIPO_PRODUTO_DESC']) . '">';
            echo '</form>';
        }
    }
    public static function exibirProd($Produtos, $tipo)
    {
        echo "<h2>Produtos do tipo: $tipo</h2>";
        foreach ($Produtos as $produto) {
            echo '<form action="../controls/post_CadPedido.php" method="post">';
            echo 'Nome: <input type="text" name="txtNome" value="' . htmlspecialchars($produto['TB_PRODUTO_NOME']) . '" readonly><br>';
            echo 'Preço: <input type="text" name="txtPreco" value="' . htmlspecialchars($produto['TB_PRODUTO_PREC_UNIT']) . '" readonly><br>';
            echo 'Descrição:<br> <textarea name="txtDesc" readonly>' . htmlspecialchars($produto['TB_PRODUTO_DESC']) . '</textarea><br>';
            echo '<input type="hidden" name="txtTipo" value="' . htmlspecialchars($tipo) . '">';
            echo '<input type="hidden" name="id" value="' . $produto['TB_PRODUTO_ID'] . '">';
            echo 'Quantidade: <input type="number" name="txtQuant" value="1" min="1"><br>';
            echo '<input type="submit" name="btnAddCar" value="Adicionar ao Carrinho"><br><br>';
            echo '</form><hr>';

        }
    }

    public static function exibirCarrinho($Produtos)
    {
        require_once '../models/dados.php';
        session_start();
        $produtosCar = Carrinho::getProdutos() ?? [];
        foreach ($Produtos as $produto) {
            foreach ($produtosCar as $produtoCar) {
           
            if ($produto['TB_PRODUTO_ID'] == $produtoCar['id']) {
                echo '<form action="../controls/post_CadPedido.php" method="post">';
                echo 'Nome: <input type="text" name="txtNome" value="' . htmlspecialchars($produto['TB_PRODUTO_NOME']) . '" readonly><br>';
                echo 'Preço: <input type="text" name="txtPreco" value="' . htmlspecialchars($produto['TB_PRODUTO_PREC_UNIT']) . '" readonly><br>';
                echo 'Descrição:<br> <textarea name="txtDesc" readonly>' . htmlspecialchars($produto['TB_PRODUTO_DESC']) . '</textarea><br>';
                echo '<input type="hidden" name="id" value="' . $produto['TB_PRODUTO_ID'] . '">';
                echo 'Quantidade: <input type="number" value="' . $produtoCar['Quant'] . '"  name="txtQuant" readonly ><br>';
                echo '<input type="submit" name="btnExcluir" value="Adicionar ao Carrinho"><br><br>';
                echo '</form><hr>';

            } }
        }
    }
}

class Inserts
{
    public static function addCarrinho($idProd, $quant)
    {
        require_once '../models/dados.php';
        session_start();
        // se nbao tiver nada vai vazio
        $produtos = Carrinho::getProdutos() ?? [];
        $atualizado = false;

        foreach ($produtos as $index => $produto) {
            if ($produto['id'] == $idProd) {
                $produtos[$index]['Quant'] = $quant;
                $atualizado = true;
                break;
            }
        }
        if (!$atualizado) {
            $produtos[] = [
                'id' => $idProd,
                'Quant' => $quant
            ];
        }
        Carrinho::set($produtos);
    }

    public static function CadClie($nome, $cpf, $tel, $end, $endNum, $idUser)
    {
        $conn = bd::ConectarBanco();

        $sql = "INSERT INTO tb_cliente
                (
                TB_CLIENTE_USERS_ID,
                TB_CLIENTE_NOME,
                TB_CLIENTE_CPF,
                TB_CLIENTE_TEL,
                TB_CLIENTE_ENDEREÇO,
                TB_CLIENTE_ENDEREÇO_NUM
                )
                values
                (
                ?,?,?,?,?,?
                )";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("issssi", $idUser, $nome, $cpf, $tel, $end, $endNum);
        $stmt->execute();
        $stmt->close();
        $conn->close();

    }

    public static function UpdateClie($nome, $cpf, $tel, $end, $endNum, $idUser)
    {
        $conn = bd::ConectarBanco();

        $sql = "UPDATE tb_cliente
                SET 
                TB_CLIENTE_USERS_ID = ?,
                TB_CLIENTE_NOME = ?,
                TB_CLIENTE_CPF = ?,
                TB_CLIENTE_TEL = ?,
                TB_CLIENTE_ENDEREÇO = ?,
                TB_CLIENTE_ENDEREÇO_NUM = ?
                WHERE TB_CLIENTE_CPF = ?";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("issssis", $idUser, $nome, $cpf, $tel, $end, $endNum, $cpf);
        $stmt->execute();
        $stmt->close();
        $conn->close();

    }

    public static function CadProd($nome, $idTipo, $precoUn, $desc)
    {
        $conn = bd::ConectarBanco();

        $sql = "INSERT INTO TB_PRODUTO 
                (
                TB_PRODUTO_NOME,
                TB_PRODUTO_TIPO_PRODUTO_ID,
                TB_PRODUTO_PREC_UNIT,
                TB_PRODUTO_DESC             
                )
                values
                (
                ?,?,?,?
                )";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("sids", $nome, $idTipo, $precoUn, $desc);
        $stmt->execute();
        $stmt->close();
        $conn->close();

    }

    public static function CadTipoProd($desc)
    {
        $conn = bd::ConectarBanco();

        $sql = "INSERT INTO TB_TIPO_PRODUTO 
                (
                TB_TIPO_PRODUTO_DESC             
                )
                values
                (
                ?
                )";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("s", $desc);
        $stmt->execute();
        $stmt->close();
        $conn->close();

    }

    public static function CadUsers($email, $senha)
    {
        require_once '../models/dados.php';
        session_start();
        $tipo = NewUsers::getTipo();
        $id = Querys::IdUsers();
        $conn = bd::ConectarBanco();
        $sql = "INSERT INTO tb_users 
                            (
                            tb_users_id,
                            tb_users_email,
                            tb_users_senha,
                            tb_users_tipo
                            ) values 
                            (
                            ?,?,?,?
                            )";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("isss", $id, $email, $senha, $tipo);
        $stmt->execute();
        $stmt->close();
        $conn->close();
        return $id;
    }

}

class Querys
{
    public static function Produtos()
    {
        $conn = bd::ConectarBanco();
        // Buscar produtos do banco filtrando pelo tipo
        $sql = " SELECT * FROM TB_PRODUTO";
        $stmt = $conn->prepare($sql);
        $stmt->execute();
        $result = $stmt->get_result();
        $produtos = $result->fetch_all(MYSQLI_ASSOC);
        $stmt->close();
        $conn->close();
        return $produtos;
    }
    public static function ProdutosPorTipo($tipo)
    {
        $conn = bd::ConectarBanco();

        // Buscar produtos do banco filtrando pelo tipo
        $sql = " SELECT p.TB_PRODUTO_ID,
                            p.TB_PRODUTO_NOME,
                            p.TB_PRODUTO_DESC,
                            p.TB_PRODUTO_PREC_UNIT,
                            t.TB_TIPO_PRODUTO_DESC
                            FROM tb_produto p
                            INNER JOIN tb_tipo_produto t 
                            ON p.TB_PRODUTO_TIPO_PRODUTO_ID = t.TB_TIPO_PRODUTO_ID
                            WHERE t.TB_TIPO_PRODUTO_DESC = ?;";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("s", $tipo);
        $stmt->execute();
        $result = $stmt->get_result();
        $produtos = $result->fetch_all(MYSQLI_ASSOC);
        $stmt->close();
        $conn->close();
        return $produtos;
    }

    public static function infoSCliente($idCliente): array
    {
        $conn = bd::ConectarBanco();

        $sql = "SELECT * FROM TB_CLIENTE WHERE TB_CLIENTE_ID = ? LIMIT 1";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("s", $idCliente);
        $stmt->execute();
        $result = $stmt->get_result();
        $row = $result->fetch_assoc();

        $stmt->close();
        $conn->close();

        if (!$row) {
            return [];
        }

        return [
            "nome" => $row['TB_CLIENTE_NOME'],
            "cpf" => $row['TB_CLIENTE_CPF'],
            "tell" => $row['TB_CLIENTE_TEL'],
            "endereco" => $row['TB_CLIENTE_ENDEREÇO'],
            "numero" => $row['TB_CLIENTE_ENDEREÇO_NUM']
        ];
    }

    public static function idClient($idUser): mixed
    {
        $conn = bd::ConectarBanco();

        $sql = "SELECT TB_CLIENTE_ID FROM TB_CLIENTE WHERE TB_CLIENTE_USERS_ID = ? LIMIT 1";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("s", $idUser);
        $stmt->execute();
        $result = $stmt->get_result();
        $row = $result->fetch_assoc();

        $stmt->close();
        $conn->close();

        return $row['TB_CLIENTE_ID'];
    }

    public static function Login($email, $senha)
    {
        require_once '../models/dados.php';

        $conn = bd::ConectarBanco();
        $sql = "SELECT * FROM TB_USERS 
                WHERE TB_USERS_EMAIL = '$email'
                and TB_USERS_SENHA = '$senha'";
        $result = $conn->query($sql);
        $row = $result->fetch_assoc();

        // se existir 
        if ($row) {
            // inicio imnha sessao
            session_start();
            $idCliente = Querys::idClient($row["TB_USERS_ID"]);
            SessaoUsers::set($row["TB_USERS_EMAIL"], $row["TB_USERS_SENHA"], $row["TB_USERS_TIPO"], $idCliente);
            header('Location: ../views/MainMenu.php');
            exit;
        } else {
            include '../views/index.php';
            echo '<center>LOGIN OU SENHA INCORRETOS<center>';
        }

        $result->close();
        $conn->close();
    }
    public static function IdUsers()
    {
        $conn = bd::ConectarBanco();
        // comando sql
        $sql = "SELECT TB_USERS_ID FROM TB_USERS";
        // envio e pego  o resultado 
        $result = $conn->query($sql);
        // pego o numero de linhas para pegar o proximo id
        // !! adcionar tratamneto caso nao exista linhas ainda.
        return $result->num_rows + 1;
    }

    public static function tiposProd()
    {
        // deixar ig7ual infosclie
        $conn = bd::ConectarBanco();
        $sql = "SELECT * FROM tb_tipo_produto";
        $result = $conn->query($sql);

        $tipos = $result->fetch_all(MYSQLI_ASSOC);

        $conn->close();
        return $tipos;
    }

    public static function emailUsersExists($email)
    {
        $conn = bd::ConectarBanco();

        $sql = "SELECT * FROM TB_USERS WHERE TB_USERS_email = ? LIMIT 1";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("s", $email);
        $stmt->execute();
        $result = $stmt->get_result();

        $exists = $result->num_rows > 0;

        $stmt->close();
        $conn->close();

        return $exists;
    }

    public static function CpfExists($cpf)
    {
        $conn = bd::ConectarBanco();

        $sql = "SELECT * FROM TB_CLIENTE WHERE TB_CLIENTE_CPF = ? LIMIT 1";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("s", $cpf);
        $stmt->execute();
        $result = $stmt->get_result();

        $exists = $result->num_rows > 0;

        $stmt->close();
        $conn->close();

        return $exists;
    }

    public static function ehDefault($cpf)
    {
        $conn = bd::ConectarBanco();

        $sql = "SELECT * FROM TB_CLIENTE WHERE TB_CLIENTE_CPF = ? and TB_CLIENTE_Users_id = 1  LIMIT 1";
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("s", $cpf);
        $stmt->execute();
        $result = $stmt->get_result();

        $exists = $result->num_rows > 0;

        $stmt->close();
        $conn->close();

        return $exists;
    }

}


?>