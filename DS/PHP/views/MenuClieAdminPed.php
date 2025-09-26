<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>
</head>
<?php
require_once '../controls/funcoes.php';
 $Clientes = Querys::Clientes();
?>

<body>
    <center>
        <h3>Infos Cliente</h3>
        <form action="" method="post">
        <form action="../controls/post_CadUsers.php" method="post">
            <select name="txtClie" id="">
                <option>Selecione o Cliente<option>
                <?php Exibir::exibirClientesSelect($Clientes) ?>
            </select><br><br>
            digite seu nome: <input type="text" name="txtNome" required> <br><br>
            digite seu cpf: <input type="text" name="txtCpf" required><br><br>
            digite seu telefone: <input type="tel" name="txtTel" required><br><br>
            digite seu endereço: <input type="text" name="txtEnd" required><br><br><hr>
        </form>
    </center>
</body>
</html>