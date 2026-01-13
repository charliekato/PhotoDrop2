# PhotoDrop
 スマホの写真をパソコンにupload するツールです。スマホではなくWindows PC にインストールします。
 
# インストール
 [PhotoDrop.msi](https://drive.google.com/file/d/1cfQaO5ygQRSLdWKnVO9D_Rz9xmHFySEs/view?usp=sharing) をダブルクリックしてインストールします。
 

# 使い方
  PhotoDrop のアイコンをダブルクリックするとQR Code がデスクトップに表示されるのでそれをスマホで読み取ります。
   ![](https://github.com/charliekato/PhotoDrop2/blob/master/image1.png =300x )
  スマホに上のようなの画面が表示されるので
  写真を選択し、「PCにコピー」を押します。PCのピクチャーフォルダーにその日の日付のサブフォルダー
  ができているのでその中に写真が保存されます。
 
　写真は複数枚同時に送れますが、合計サイズは 50Mバイトまでに制限されています。
　動画は送れません。

# ソースコード
 このプログラムは二つのプログラムが必要です。一つはPhotoDrop2.exe もう一つは PhotoUpLoader.exe です。
 前者はQR code を出すだけのプログラムです。後者は裏で動いておりスマホからの写真をしかるべきフォルダーに
 保存するサーバーです。どちらもgit にソースコードを公開しています。
   [https://github.com/charliekato/PhotoDrop2](https://github.com/charliekato/PhotoDrop2)  <br>
   [https://github.com/charliekato/PhotoUpLoader](https://github.com/charliekato/PhotoUpLoader)
# ライセンス
　GPL です。<br>
This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or any later version.
This program is distributed in the hope that it will be useful,    but WITHOUT ANY WARRANTY; without even the implied warranty of    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the    GNU General Public License for more details.
You should have received a copy of the GNU General Public License    along with this program.  If not, see <https://www.gnu.org/licenses/>.
    This program comes with ABSOLUTELY NO WARRANTY; 


