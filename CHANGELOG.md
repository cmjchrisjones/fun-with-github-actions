# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog][Keep a Changelog] and this project adheres to [Semantic Versioning][Semantic Versioning].

## [Unreleased]

---

## [Released]

## [2.0.4] - 2021-02-1

### Changed

- Replaced [actions/create-release@v1](https://github.com/actions/create-release) with [softprops/action-gh-release@v1](https://github.com/softprops/action-gh-release)

## [2.0.3] - 2021-02-01

### Changed

- Changed `tag_name` to `${{ github.ref }}`.

## [2.0.2] - 2020-12-31

### Fixed

- Fixed created tag not being `vX.Y.Z`

## [2.0.1] - 2020-12-19

### Fixed

- [actions/create-release@v1](https://github.com/actions/create-release) not uploading files, using [NBTX/upload-release-assets](https://github.com/NBTX/upload-release-assets) to upload multiple files because [actions/upload-release-asset](https://github.com/actions/upload-release-asset) only works for 1 file.

## [2.0.0] - 2020-12-19

### Changed

- Swapped from [glennawatson/ChangeLog](https://github.com/glennawatson/ChangeLog) to [mindsers/changelog-reader-action](https://github.com/mindsers/changelog-reader-action).
- Swapped from [softprops/action-gh-release](https://github.com/softprops/action-gh-release) to [actions/create-release](https://github.com/actions/create-release).
- Change release pipeline trigger from on published released to on pushed with tag `v*`.

---

<!-- Links -->
[Keep a Changelog]: https://keepachangelog.com/
[Semantic Versioning]: https://semver.org/

<!-- Versions -->
[Unreleased]: https://github.com/erri120/fun-with-github-actions/compare/v2.0.4...HEAD
[Released]: https://github.com/erri120/fun-with-github-actions/releases
[2.0.4]: https://github.com/erri120/fun-with-github-actions/compare/v2.0.3..v2.0.4
[2.0.3]: https://github.com/erri120/fun-with-github-actions/compare/v2.0.2..v2.0.3
[2.0.2]: https://github.com/erri120/fun-with-github-actions/compare/v2.0.1..v2.0.2
[2.0.1]: https://github.com/erri120/fun-with-github-actions/compare/v2.0.0..v2.0.1
[2.0.0]: https://github.com/erri120/fun-with-github-actions/releases/v2.0.0
