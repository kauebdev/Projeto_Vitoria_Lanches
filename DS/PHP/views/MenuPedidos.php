<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>vitoria lanches</title>
</head>
<style>
    .tipos {
        justify-content: center;
        display: flex;
        gap: 10px;
        flex-wrap: wrap;
    }

    .tipos form {
        margin: 0;
    }

    .nav {
        position: fixed;
        left: 90%;
    }
</style>
<?php
require_once '../controls/funcoes.php';
$tipos = Querys::tiposProd();
$produtos = [];
$tipoSelecionado = $_POST['btntipo'] ?? '';
if (isset($_POST['btntipo'])) {
    $produtos = Querys::ProdutosPorTipo($tipoSelecionado) ?? [];
}
?>

<body>
    <center>
        <div class="container">
            <div class="nav">
                <form action="../controls/post_CadPedido.php" method="post">
                    <input type="submit" value="Ver Carrinho" name='btnCar'><br><br>
                </form>
            </div>
            <div class="tipos">
                <?php Exibir::exibirTiposProd($tipos) ?>
            </div>
            <div class="produtos">
                <?php Exibir::exibirProdporTipo($produtos, $tipoSelecionado) ?>
                =
            </div>
        </div>
    </center>
</body>

</html>