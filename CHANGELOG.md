# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Changed

- Migrated from `thomaseizinger/keep-a-changelog-new-release` to `baynezy/ChangeLogger.Action` (#210)
- Added GH_TOKEN environment variable to all GitHub Action workflows for consistent token access (#215)

## [1.1.1.16] - 2025-06-06

### Fixed

- Upgraded to .Net 9 as the latest Docker image was not compatible with .Net 8. (#204)

## [1.1.0.12] - 2025-06-05

### Fixed

- Fixed Dependabot configuration to correctly locate Dockerfile for dependency tracking. [#195](https://github.com/Afterlife-Guide/SemVer.Action/issues/195)

## [1.0.9.11] - 2025-04-10

## [1.0.8.10] - 2025-03-13

## [1.0.7.9] - 2025-02-12

## [1.0.6.8] - 2025-01-16

## [1.0.5.7] - 2024-11-13

## [1.0.4.6] - 2024-10-14

### Fixed

- Removed all usage of `set-output` in GitHub Actions.

## [1.0.3.8] - 2024-03-25

## [1.0.2.7] - 2024-03-25

## [1.0.1.6] - 2024-03-25

## [1.0.0.5] - 2024-03-25

## [0.2.0.3] - 2024-03-22

## [0.1.1.2] - 2024-03-22

## [0.1.0.1] - 2024-03-22

[unreleased]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.1.1.16...HEAD
[1.1.1.16]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.1.0.12...1.1.1.16
[1.1.0.12]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.0.9.11...1.1.0.12
[1.0.9.11]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.0.8.10...1.0.9.11
[1.0.8.10]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.0.7.9...1.0.8.10
[1.0.7.9]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.0.6.8...1.0.7.9
[1.0.6.8]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.0.5.7...1.0.6.8
[1.0.5.7]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.0.4.6...1.0.5.7
[1.0.4.6]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.0.3.8...1.0.4.6
[1.0.3.8]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.0.2.7...1.0.3.8
[1.0.2.7]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.0.1.6...1.0.2.7
[1.0.1.6]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.0.0.5...1.0.1.6
[1.0.0.5]: https://github.com/Afterlife-Guide/SemVer.Action/compare/0.2.0.3...1.0.0.5
[0.2.0.3]: https://github.com/Afterlife-Guide/SemVer.Action/compare/0.1.1.2...0.2.0.3
[0.1.1.2]: https://github.com/Afterlife-Guide/SemVer.Action/compare/0.1.0.1...0.1.1.2
[0.1.0.1]: https://github.com/Afterlife-Guide/SemVer.Action/compare/4504613496b5d76d18531a4c41b3b88d241c41c2...0.1.0.1
