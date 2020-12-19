# Changelog

Based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).

## [Unreleased]

## [2.0.1] - 2020-12-19

### Fixed

- fixed [actions/create-release@v1](https://github.com/actions/create-release) not uploading files, using [NBTX/upload-release-assets](https://github.com/NBTX/upload-release-assets) to upload multiple files because [actions/upload-release-asset](https://github.com/actions/upload-release-asset) only works for 1 file.

## [2.0.0] - 2020-12-19

### Changed

- Swapped from [glennawatson/ChangeLog](https://github.com/glennawatson/ChangeLog) to [mindsers/changelog-reader-action](https://github.com/mindsers/changelog-reader-action).
- Swapped from [softprops/action-gh-release](https://github.com/softprops/action-gh-release) to [actions/create-release](https://github.com/actions/create-release).
- Change release pipeline trigger from on published released to on pushed with tag `v*`.
