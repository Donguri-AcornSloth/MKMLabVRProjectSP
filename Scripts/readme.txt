弾のモデル→BulletMoveをアタッチ
銃のモデル→GunManagerをアタッチ＆弾のモデルをGunManagerのBullet変数へ
得点のUI→ScoreManagerをアタッチ
的のモデル→TargetManagerをアタッチ＆ScoreのText（Canvas→ScoreText）をScoreManager変数へ
三人称→CameraManagerをDollyとかにアタッチ＆CenterEyeAnchorとMainCameraを変数へ、あとはTPSTriggerIn/Outを配置する