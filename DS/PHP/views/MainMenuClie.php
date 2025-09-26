<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <center>
        <h1>VITORIA LANCHES</h1>
        <h2>AREA DO CLIENTE </h2>
        <?php
        require_once '../models/dados.php';
        require_once '../controls/funcoes.php';
        $idCliente = SessaoUsers::getIdCliente();
        $cliente = Querys::infoSCliente($idCliente);
        if (!empty($cliente)) {
            echo "Bem Vindo <b>" . $cliente['nome'] . "</b> !<br>";
            echo "CPF: " . $cliente['cpf'] . "<br>";
            echo "Fone: " . $cliente['tell'] . "<br>";
            echo "Endereço: " . $cliente['endereco'] . ", " . $cliente['numero'] . "<br><br>";
        } else {
            echo "Cliente não encontrado!";
        }


        ?>
        <form action="../controls/post_MainMenu.php" method="post">
            <input type="submit" value="pedidos" name="btnPed"><br><br>
        </form>
    </center>
</body>

</html>