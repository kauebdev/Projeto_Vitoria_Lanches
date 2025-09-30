<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>VITORIA LANCHES</title>
</head>

<?php
require_once '../controls/funcoes.php';
require_once '../models/dados.php';
$tipos = Querys::tiposProd();
session_start();
?>

<body>
    <center>
        <h1>Atualização de Produto</h1>

        <form action="../controls/post_UpProd.php" method="post">
            Nome do produto: 
            <input type="text" name="txtNome" value="<?php echo Prod::getNome(); ?>" required><br><br>

            escolha o tipo:
            <select name="IdTipo">
                <option value="0">Selecione Tipo</option>
                <?php Exibir::exibirTiposSelect($tipos) ?>
            </select><br><br>

            o preço Unitario: 
            <input type="number" step="0.01" name="txtPrecoUn" 
                   value="<?php echo Prod::getPreco(); ?>" required><br><br>

            a descrição:<br><br>
            <textarea name="txtDesc" placeholder="descrição.."><?php echo Prod::getDesc(); ?></textarea> <br><br>

            <input type="hidden" name="id" value="<?php echo Prod::getId(); ?>">
            
            <input type="submit" value="Atualizar" name="btnUpd"> <br><br>
        </form>

        <form action="../controls/post_CadProd.php" method="post">
            <input type="submit" value="voltar" name="btnVoltar"><br><br>
        </form>
    </center>
</body>


</html>