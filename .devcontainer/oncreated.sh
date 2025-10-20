#! /bin/bash
set -e

ARCH=$(dpkg --print-architecture)

SERVER_VERSION=10.11.0
SERVER_FILE=jellyfin_${SERVER_VERSION}-${ARCH}.tar.gz
FFMPEG_VERSION=7.1.2-3
FFMPEG_FILE=jellyfin-ffmpeg7_${FFMPEG_VERSION}-bookworm_${ARCH}.deb

# Install Jellyfin Server
curl -L https://repo.jellyfin.org/files/server/linux/stable/v${SERVER_VERSION}/${ARCH}/${SERVER_FILE} | sudo tar zxv -C /opt

# Install Jellyfin FFmpeg 7.x
curl -LO https://repo.jellyfin.org/files/ffmpeg/debian/7.x/${FFMPEG_VERSION}/${ARCH}/${FFMPEG_FILE}
sudo apt-get update
sudo apt-get install -y ./${FFMPEG_FILE}
rm ${FFMPEG_FILE}
