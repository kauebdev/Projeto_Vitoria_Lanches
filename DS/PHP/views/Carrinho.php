<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<?php
require_once '../controls/funcoes.php';
    $produtos = Querys::Produtos();
?>
<body>
    <center>
        <h1>Vitoria Lanches</h1>
        <h2>Carrinho</h2>
        <?php
        require_once '../models/dados.php';
        require_once '../controls/funcoes.php';
        session_start();
        $idCliente = SessaoUsers::getIdCliente();
        $cliente = Querys::infoSCliente($idCliente);
        if (!empty($cliente)) {
            echo "Cliente: <b>" . $cliente['nome'] . "</b><br>";
            echo "CPF: " . $cliente['cpf'] . "<br>";
            echo "Fone: " . $cliente['tell'] . "<br>";
            echo "Endereço: " . $cliente['endereco'] . ", " . $cliente['numero'] . "<br><br>";
        } else {
            echo "Cliente não encontrado!";
        }


        ?>
        <for
        <form action="" method="post">
            <?php Exibir::exibirCarrinho($produtos) ?>
        </form>
    </center>
</body>
</html>