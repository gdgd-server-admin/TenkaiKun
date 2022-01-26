# 展開くん

これはサーバとクライアントをセットで使うよ

## やりたいこと（やってほしいこと）＆やりたくないこと（やってほしくないこと）

LAN内の複数の端末にツールを配布しないといけない状況で

- サクッと配りたい
- あれこれ手順書を作りたくない
- ツールを更新したらちゃんと受け取ってほしい
- 「不具合でぇす！直ってませぇん！→バージョンが古いだけでした」←これやめたい

## 展開くんサーバ

中身はHTTPサーバ。自動更新に必要なメタデータと展開対象のZIPファイルを提供するファイルサーバ＋WebAPIサーバ  
運用時はnetshでポートの予約が必要

```netsh  
http
add urlacl http://(待ち受けたいIPアドレス):24680/ user=(実行ユーザ)
```
管理者権限のコマンドプロンプトで↑を実行してから展開くんサーバの設定をして再起動する

## 展開くんクライアント

展開くんサーバで生成したショートカットファイルを食わせると更新チェックして最新版だったらツールが起動する

## 自分でビルドする

Visual Studioでリリースビルドした後にインストーラーのフォルダに出来上がったものを入れてInnoSetupでコンパイル

## そもそも

展開くんで使ってるライブラリを最初から組み込んで作ってれば展開くんは要らないんだよ  
