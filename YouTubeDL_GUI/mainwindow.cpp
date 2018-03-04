#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "QMouseEvent"
#include "QClipboard"
#include "QDir"
#include "QProcess"
#include "QMessageBox"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    //Initialize
    setWindowFlags(Qt::WindowStaysOnTopHint|Qt::FramelessWindowHint);
    process = new QProcess(this);
    fProcess = new QProcess(this);
    this->statusBar()->showMessage("Ready.");
    ui->LB_clear->setVisible(false);
    ui->PTE_xe->setVisible(false);

    // Win Buttons
    connect(ui->LB_close, SIGNAL(clicked()), this, SLOT(close()));
    connect(ui->LB_mini, SIGNAL(clicked()), this, SLOT(miniWin()));
    connect(ui->LB_update, SIGNAL(clicked()), this, SLOT(updateDL()));
    connect(ui->PTE_url, SIGNAL(textChanged()), this, SLOT(showClearButton()));
    connect(ui->RB_video, SIGNAL(clicked(bool)), this, SLOT(showXE()));
    connect(ui->RB_Audio, SIGNAL(clicked(bool)), this, SLOT(showXE()));
    connect(ui->RB_xFormat, SIGNAL(clicked(bool)), this, SLOT(showXE()));
    connect(ui->LB_clear, SIGNAL(clicked()), this, SLOT(clearURL()));
    connect(process, SIGNAL(readyReadStandardOutput()), this, SLOT(readOutput()));
    connect(process, SIGNAL(started()), this, SLOT(disableButtons()));
    connect(process, SIGNAL(finished(int)), this, SLOT(finishDownload()));
    connect(fProcess, SIGNAL(readyReadStandardOutput()), this, SLOT(fReadOutput()));
    connect(fProcess, SIGNAL(started()), this, SLOT(disableButtons()));
    connect(fProcess, SIGNAL(finished(int)), this, SLOT(fFinishDownload()));
}

MainWindow::~MainWindow()
{
    delete ui;
}

// Make window dragable
void MainWindow::mousePressEvent(QMouseEvent *event) {
    m_nMouseClick_X_Coordinate = event->x();
    m_nMouseClick_Y_Coordinate = event->y();

    if(event->button() == Qt::RightButton){
        //Get Text from Clipboard
        QClipboard *board = QApplication::clipboard();
        QString url = board->text();
        ui->PTE_url->document()->setPlainText(url);
    }
}
void MainWindow::mouseMoveEvent(QMouseEvent *event) {
    move(event->globalX()-m_nMouseClick_X_Coordinate,event->globalY()-m_nMouseClick_Y_Coordinate);
}

// Win Functions
void MainWindow::miniWin(){
    setWindowState(Qt::WindowMinimized);
}
void MainWindow::updateDL(){
    process->start("youtube-dl.exe -U");
}

void MainWindow::disableButtons(){
    ui->PB_dl->setEnabled(false);
    ui->PB_find->setEnabled(false);
    ui->LB_update->setEnabled(false);
}
void MainWindow::finishDownload(){
    this->statusBar()->showMessage("Done.");
    ui->PB_dl->setEnabled(true);
    ui->PB_find->setEnabled(true);
    ui->LB_update->setEnabled(true);
}
void MainWindow::fFinishDownload(){
    this->statusBar()->showMessage("Done.");
    ui->PB_dl->setEnabled(true);
    ui->PB_find->setEnabled(true);
    ui->LB_update->setEnabled(true);
    //add context
}
void MainWindow::readOutput(){
    this->statusBar()->showMessage(process->readAllStandardOutput());
}
void MainWindow::fReadOutput(){
    QString a = fProcess->readAllStandardOutput();
    context.append(a);
    this->statusBar()->showMessage(a);
}
void MainWindow::showClearButton(){
    if(ui->PTE_url->toPlainText().length() == 0){
        ui->LB_clear->setVisible(false);
    }else{
        ui->LB_clear->setVisible(true);
    }
}
void MainWindow::showXE(){
    if(ui->RB_xFormat->isChecked()){
        ui->PTE_xe->setVisible(true);
    }else{
        ui->PTE_xe->setVisible(false);
    }
}
void MainWindow::clearURL(){
    ui->PTE_url->clear();
}

// Download Functions
void MainWindow::on_PB_dl_clicked(){
    if(ui->CB_isList->isChecked()){
        arg2py = " -o \""+QDir::homePath()+"/Videos/%(playlist_index)s-%(title)s%(format)s.%(ext)s\"";
        which2dl();
        process->start("youtube-dl.exe"+arg2py);
    }else{
        arg2py = " --no-playlist -o \""+QDir::homePath()+"/Videos/%(title)s%(format)s.%(ext)s\"";
        which2dl();
        process->start("youtube-dl.exe"+arg2py);
    }
}
void MainWindow::which2dl(){
    if(ui->RB_video->isChecked()){
        arg2py = arg2py+" -f bestvideo[ext=mp4]+bestaudio[ext=m4a] -i \""+ui->PTE_url->toPlainText()+"\"";
    }else if(ui->RB_Audio->isChecked()){
        arg2py = arg2py+" -f bestaudio  -x  --audio-format mp3 --audio-quality 320k -i \""+ui->PTE_url->toPlainText()+"\"";
    }else{
        arg2py = arg2py+" -f \""+ui->PTE_xe->toPlainText()+"\" -i "+ui->PTE_url->toPlainText()+"\"";
    }
}

// Find Resolutions
void MainWindow::on_PB_find_clicked(){
    context.clear();
    arg2py = " --no-playlist -F \""+ui->PTE_url->toPlainText()+"\"";
    fProcess->start("youtube-dl.exe"+arg2py);
}
