<?php
if ($_POST) {
    if (isset($_POST['btnTipo'])) {
        header('Location: ../views/CadTipoProd.php');
        exit;
    }

    if (isset($_POST['btnCadProd'])) {
        require_once 'funcoes.php';
        $nome = $_POST['txtNome'];
        $idTipo = $_POST['IdTipo'];
        $precoUn= $_POST['txtPreçoUn'];
        $desc = $_POST['txtDesc'];
        Inserts::CadProd($nome , $idTipo, $precoUn, $desc);
        header('Location: ../views/CadProd.php');
        exit;
    }
    if (isset($_POST['btnCadTipoProd'])) {
        require_once 'funcoes.php';
        $desc = $_POST['txtDesc'];
        Inserts::CadTipoProd($desc);
        header('Location: ../views/CadProd.php');
        exit;
    }
    if (isset($_POST['btnVoltar'])) {
        if (isset($_SERVER['HTTP_REFERER'])) {
            header("Location: " . $_SERVER['HTTP_REFERER']);
            exit;
        } else {
            header("Location: index.php"); // fallback
            exit;
        }
    }
}

?>