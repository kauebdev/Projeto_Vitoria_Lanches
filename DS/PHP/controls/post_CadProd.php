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
        $precoUn = $_POST['txtPreçoUn'];
        $desc = $_POST['txtDesc'];
        Inserts::CadProd($nome, $idTipo, $precoUn, $desc);
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

    if (isset($_POST['btnUpd'])) {
        require_once '../models/dados.php';
        session_start();
        $nome = $_POST['txtNome'];
        $idTipo = $_POST['IdTipo'];
        $precoUn = $_POST['txtPreçoUn'];
        $desc = $_POST['txtDesc'];
        $id = $_POST['id'];
        Prod::set($id, $nome, $idTipo, $precoUn, $desc);
        header('Location: ../views/UpProd.php');
        exit;
    }
    if (isset($_POST['btnDel'])) {
        require_once '../controls/funcoes.php';
        $id = $_POST['id'];
        Deletes::DeleteProd( $id);
        header("Location: ../views/CadProd.php");
        exit;
    }
}

?>