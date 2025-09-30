<?php
if ($_POST) {
    if (isset($_POST['btnUpd'])) {
        require_once '../controls/funcoes.php';
        $nome = $_POST['txtNome'];
        $idTipo = $_POST['IdTipo'];
        $precoUn= $_POST['txtPrecoUn'];
        $desc = $_POST['txtDesc'];
        $id = $_POST['id'];
        Inserts::UpdateProd($nome, $idTipo, $precoUn, $desc, $id);
        header("Location: ../views/CadProd.php");
        exit;
    }
}
?>