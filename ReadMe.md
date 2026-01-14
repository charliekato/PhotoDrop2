# PhotoDrop
 スマホの写真をパソコンにupload するツールです。スマホではなくWindows PC にインストールします。
 PC上でこのアプリを立ち上げるとQR code が出てくるのでそれをスマホで読み込んでその後はスマホ側で操作します。
 
# インストール

 Windows installer (file名 : PhotoDrop1.0.2.msi) を ダウンロードして実行。
 

# 使い方
  PhotoDrop のアイコンをダブルクリックするとQR Code がデスクトップに表示されるのでそれをスマホで読み取ります。
<img width="367" height="252" alt="Image" src="https://github.com/user-attachments/assets/86bd4cb0-b468-4440-a2e3-144e5721487e" />

  スマホに上のようなの画面が表示されるので
  「写真を選択」を押して写真を選択し、「PCにコピー」を押します。PCのピクチャーフォルダーにその日の日付のサブフォルダー
  ができているのでその中に写真が保存されます。
 
　写真は複数枚同時に送れますが、合計サイズは 50Mバイトまでに制限されています。
　動画は送れません。

# ソースコード
 このプログラムは二つのプログラムが必要です。一つはPhotoDrop2.exe もう一つは PhotoUpLoader.exe です。Installerを実行すればどちらもインストールされます。
 前者はQR code を出すだけのプログラムです。後者は裏で動いておりスマホからの写真をしかるべきフォルダーに
 保存するサーバーです。PhotoUpLoader は別のrepository (下記) にソースコードを公開しています。<br>
   
   <https://github.com/charliekato/PhotoUpLoader>
# ライセンス
　GPL です。<br>
This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or any later version.
This program is distributed in the hope that it will be useful,    but WITHOUT ANY WARRANTY; without even the implied warranty of    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the    GNU General Public License for more details.
You should have received a copy of the GNU General Public License    along with this program.  If not, see <https://www.gnu.org/licenses/>. <br>
    This program comes with ABSOLUTELY NO WARRANTY; 


