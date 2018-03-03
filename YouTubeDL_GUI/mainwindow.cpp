#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "QMouseEvent"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    //Initialize
    setWindowFlags(Qt::WindowStaysOnTopHint|Qt::FramelessWindowHint);
    ui->LB_clear->setVisible(false);
    ui->PTE_xe->setVisible(false);

    // Win Buttons
    connect(ui->LB_close, SIGNAL(clicked()), this, SLOT(close()));
    connect(ui->LB_mini, SIGNAL(clicked()), this, SLOT(miniWin()));
    connect(ui->PTE_url, SIGNAL(textChanged()), this, SLOT(showClearButton()));
    connect(ui->RB_video, SIGNAL(clicked(bool)), this, SLOT(showXE()));
    connect(ui->RB_Audio, SIGNAL(clicked(bool)), this, SLOT(showXE()));
    connect(ui->RB_xFormat, SIGNAL(clicked(bool)), this, SLOT(showXE()));
    connect(ui->LB_clear, SIGNAL(clicked()), this, SLOT(clearURL()));

}

MainWindow::~MainWindow()
{
    delete ui;
}

// Make window dragable
void MainWindow::mousePressEvent(QMouseEvent *event) {
    m_nMouseClick_X_Coordinate = event->x();
    m_nMouseClick_Y_Coordinate = event->y();
}
void MainWindow::mouseMoveEvent(QMouseEvent *event) {
    move(event->globalX()-m_nMouseClick_X_Coordinate,event->globalY()-m_nMouseClick_Y_Coordinate);
}

// Win Functions
void MainWindow::miniWin(){
    setWindowState(Qt::WindowMinimized);
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
