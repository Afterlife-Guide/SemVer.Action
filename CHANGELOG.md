# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [1.3.2.18] - 2026-01-16

## [1.3.1.17] - 2025-12-10

### Fixed

- Bug with deployment (#306)

### Security

- Fixed command injection vulnerabilities in GitHub Actions workflows by moving user-controlled data to environment variables instead of using them directly in run blocks (#300)

## [1.3.0.15] - 2025-11-18

### Changed

- Upgraded all projects and CI/CD pipelines to .NET 10 (#288)

## [1.2.2.14] - 2025-11-07

## [1.2.1.19] - 2025-09-09

## Changed

- Reverted Docker non-root (#240)

## [1.2.0.13] - 2025-09-08

### Fixed

- Fixed security vulnerability by preventing direct use of user-controlled data in workflow run blocks to prevent command injection

### Changed

- Migrated from `thomaseizinger/keep-a-changelog-new-release` to `baynezy/ChangeLogger.Action` (#210)
- Added GH_TOKEN environment variable to all GitHub Action workflows for consistent token access (#215)
- Set up copilot environment (#225)
- Updated Dockerfile to use uppercase 'AS' in multi-stage builds for SonarQube compliance (#229)

### Fixed

- Reduced Information logging calls in WriteJsonCommand.cs to comply with SonarQube rule S6664 (#230)

### Security

- Updated all external GitHub Actions to use full commit SHA hashes instead of version tags for improved security (#235)
- Updated Docker image to run as non-root user instead of root user to improve security posture (#233)

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

[unreleased]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.3.2.18...HEAD
[1.3.2.18]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.3.1.17...1.3.2.18
[1.3.1.17]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.3.0.15...1.3.1.17
[1.3.0.15]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.2.2.14...1.3.0.15
[1.2.2.14]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.2.1.19...1.2.2.14
[1.2.1.19]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.2.0.13...1.2.1.19
[1.2.0.13]: https://github.com/Afterlife-Guide/SemVer.Action/compare/1.1.1.16...1.2.0.13
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
