<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>VITORIA LANCHES</title>
</head>

<?php
require_once '../controls/funcoes.php';
$tipos = Querys::tiposProd();
?>

<body>
    <center>
        <h1>Cadastro de Produto</h1>

        <form action="../controls/post_CadProd.php" method="post">
            digite o Nome do produto: <input type="text" name="txtNome" required><br><br>
            escolha o tipo:
            <select name="IdTipo">
                <option value="0">Selecione Tipo</option>
                <?php foreach ($tipos as $tipo): ?>
                    <option value="<?= $tipo['TB_TIPO_PRODUTO_ID'] ?>">
                        <?= htmlspecialchars($tipo['TB_TIPO_PRODUTO_DESC']) ?>
                    </option>
                <?php endforeach; ?>
            </select>
            <input type="submit" value="novo" name="btnTipo" formnovalidate><br><br>
            digite o preço Unitario: <input type="number" name="txtPreçoUn" required><br><br>
            digite a descrição:<br><br>
            <textarea name="txtDesc" placeholder="descrição.."></textarea> <br><br>

            <input type="submit" value="Cadastrar" name="btnCadProd"> <br><br>
        </form>
        <form action="../controls/post_CadProd.php" method="post">
            <input type="submit" value="voltar" name="btnVoltar">
        </form>
    </center>
</body>

</html>